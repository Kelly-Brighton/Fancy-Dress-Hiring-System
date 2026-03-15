using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace FancyDressHiringSystem
{
    public partial class UC_Orders : UserControl
    {
        public UC_Orders()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void dataOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadOrders()
        {
            // Connection string to connect to the SQL Server database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            // Create a connection to the database
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open(); // Open the connection

                // SQL query to retrieve order details along with the costume name
                string query = @"SELECT Orders.Id,
                                Orders.CustomerName,
                                Clothes.Name AS Costume,
                                Orders.Size,
                                Orders.OrderDate,
                                Orders.Status
                            FROM Orders
                            JOIN Clothes ON Orders.CostumeId = Clothes.Id";

                // Create a SqlDataAdapter to execute the query and fill a DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataOrders.DataSource = dt;
                }

                // Create a DataGridViewComboBoxColumn for the Status column
                DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();

                // Set the properties of the status column
                statusColumn.HeaderText = "Status";
                statusColumn.DataPropertyName = "Status";

                // Add the status options to the combo box
                statusColumn.Items.Add("Pending");
                statusColumn.Items.Add("Ready for Pickup");
                statusColumn.Items.Add("Picked Up");
                statusColumn.Items.Add("Returned");
                statusColumn.Items.Add("Cancelled");

                int columnIndex = dataOrders.Columns["Status"].Index; // Get the index of the existing Status column

                dataOrders.Columns.Remove("Status"); // Remove the existing Status column

                dataOrders.Columns.Insert(columnIndex, statusColumn); // Insert the new combo box column at the same index

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(dataOrders.CurrentRow.Cells["Id"].Value); // Get the Order ID from the selected row
            string newStatus = dataOrders.CurrentRow.Cells["Status"].Value.ToString(); // Get the new status from the combo box
            string customerEmail = dataOrders.CurrentRow.Cells["CustomerEmail"].Value.ToString(); // Get the customer email from the selected row

            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open(); // Open the connection

                string query = "Update Orders SET Status=@status WHERE Id=@id"; // SQL query to update the order status

                // Create a SqlCommand to execute the update query
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@id", orderId);
                    cmd.ExecuteNonQuery(); // Execute the update query
                }
            }
            // Send an email notification to the customer about the status update
            SendEmail(customerEmail, newStatus);

            MessageBox.Show("Order status updated successfully!"); // Show a success message

            LoadOrders(); // Reload the orders to reflect the updated status
        }

        private void SendEmail(string toEmail, string status)
        {
            try
            {
                MailMessage mail = new MailMessage();

                mail.From = new MailAddress("fancydresshiring@gmail.com");
                mail.To.Add(toEmail);

                mail.Subject = "Fancy Dress Order Update";

                mail.Body = $"Hello,\n\nYour order status has been updated to: {status}.\n\nThank you for using our service.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                smtp.Credentials = new NetworkCredential("fancydresshiring@gmail.com", "vkelxobsaexirwcq");

                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message);
            }
        }
    }
}
