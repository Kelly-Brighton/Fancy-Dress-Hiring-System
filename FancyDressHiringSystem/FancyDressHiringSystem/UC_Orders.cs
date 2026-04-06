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

                    dataOrders.DataSource = null;
                    dataOrders.Columns.Clear();
                    dataOrders.AutoGenerateColumns = true;
                    dataOrders.DataSource = dt;
                    AddStatusDropdown();
                }

                // Hide email column (optional)
                if (dataOrders.Columns.Contains("CustomerEmail"))
                {
                    dataOrders.Columns["CustomerEmail"].Visible = false;
                }
            }
        }

        private void AddStatusDropdown()
        {
            // Prevent duplicate column
            if (dataOrders.Columns["Status"] is DataGridViewComboBoxColumn)
                return;

            int index = dataOrders.Columns["Status"].Index;

            // Create combo column
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = "Status";
            combo.Name = "Status";
            combo.DataPropertyName = "Status";

            combo.Items.Add("Pending");
            combo.Items.Add("Ready for Pickup");
            combo.Items.Add("Picked Up");
            combo.Items.Add("Returned");
            combo.Items.Add("Cancelled");

            // Replace column SAFELY
            dataOrders.Columns.RemoveAt(index);
            dataOrders.Columns.Insert(index, combo);
        }

        // Button click to update order status
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get selected row values
            int orderId = Convert.ToInt32(dataOrders.CurrentRow.Cells["Id"].Value);
            var statusCell = dataOrders.CurrentRow.Cells["Status"].Value;

            if (statusCell == null)
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            string newStatus = statusCell.ToString();

            // Safe retrieval of email (avoid null crash)
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

        private void dataOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

