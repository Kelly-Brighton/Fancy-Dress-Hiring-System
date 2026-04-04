using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace FancyDressHiringSystem
{
    public partial class UC_Orders : UserControl
    {
        public UC_Orders()
        {
            InitializeComponent();
            LoadOrders(); // Load orders when control is created
        }
    // Method to load all orders into the DataGridView
    private void LoadOrders()
        {
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // ✅ FIX 1: Include CustomerEmail in SELECT so we can use it later
                string query = @"SELECT Orders.Id,
                                    Orders.CustomerName,
                                    Orders.CustomerEmail,
                                    Clothes.Name AS Costume,
                                    Orders.Size,
                                    Orders.OrderDate,
                                    Orders.Status
                             FROM Orders
                             JOIN Clothes ON Orders.CostumeId = Clothes.Id";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataOrders.DataSource = dt; // Bind data to grid
                }

                // ✅ Hide email column from UI (still accessible in code)
                if (dataOrders.Columns.Contains("CustomerEmail"))
                {
                    dataOrders.Columns["CustomerEmail"].Visible = false;
                }

                // ✅ FIX 2: Prevent adding multiple ComboBox columns on reload
                if (!(dataOrders.Columns["Status"] is DataGridViewComboBoxColumn))
                {
                    DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();

                    statusColumn.HeaderText = "Status"; // Column title
                    statusColumn.DataPropertyName = "Status"; // Bind to DB column

                    // Add status options
                    statusColumn.Items.Add("Pending");
                    statusColumn.Items.Add("Ready for Pickup");
                    statusColumn.Items.Add("Picked Up");
                    statusColumn.Items.Add("Returned");
                    statusColumn.Items.Add("Cancelled");

                    // Replace existing Status column with ComboBox column
                    int columnIndex = dataOrders.Columns["Status"].Index;
                    dataOrders.Columns.Remove("Status");
                    dataOrders.Columns.Insert(columnIndex, statusColumn);
                }
            }
        }

        // Button click to update order status
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get selected row values
            int orderId = Convert.ToInt32(dataOrders.CurrentRow.Cells["Id"].Value);
            string newStatus = dataOrders.CurrentRow.Cells["Status"].Value.ToString();

            // ✅ FIX 3: Safe retrieval of email (avoid null crash)
            string customerEmail = dataOrders.CurrentRow.Cells["CustomerEmail"].Value?.ToString();

            if (string.IsNullOrEmpty(customerEmail))
            {
                MessageBox.Show("Customer email not found!");
                return;
            }

            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = "UPDATE Orders SET Status = @status WHERE Id = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@id", orderId);
                    cmd.ExecuteNonQuery(); // Execute update
                }
            }

            // Send email after updating status
            SendEmail(customerEmail, newStatus);

            MessageBox.Show("Order status updated successfully!");

            LoadOrders(); // Refresh grid
        }

        // Method to send email notification
        private void SendEmail(string toEmail, string status)
        {
            try
            {
                MailMessage mail = new MailMessage();

                mail.From = new MailAddress("fancydresshiring@gmail.com"); // sender email
                mail.To.Add(toEmail); // recipient email

                mail.Subject = "Fancy Dress Order Update";

                // Email body content
                mail.Body = $"Hello,\n\nYour order status has been updated to: {status}.\n\nThank you for using our service.";

                // SMTP configuration (Gmail)
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                smtp.Credentials = new NetworkCredential(
                    "fancydresshiring@gmail.com",
                    "vkelxobsaexirwcq"
                );

                smtp.EnableSsl = true;

                smtp.Send(mail); // Send email
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message);
            }
        }
    }
}

