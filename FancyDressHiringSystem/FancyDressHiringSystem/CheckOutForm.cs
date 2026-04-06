using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FancyDressHiringSystem
{
    public partial class CheckOut : Form
    {
        private List<BasketCard> items;

        public CheckOut(List<BasketCard> items)
        {
            InitializeComponent();
            this.items = items;
            LoadItems();
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadItems()
        {
            decimal total = 0;

            foreach (var item in items)
            {
                decimal price = decimal.Parse(item.CostumePrice);

                dataGridView1.Rows.Add(
                       item.CostumeName,
                       item.Quantity,
                       price.ToString("0.00")
                );

                total += price * item.Quantity;
            }

            lblTotal.Text = total.ToString("0.00");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtCard.Text.Trim() == "" || txtExpiry.Text.Trim() == "" || txtCVV.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your name before placing the order.");
                return;
            }
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";
            string username = Login.LoggedInUser;
            string email = Login.UserEmail;

            MessageBox.Show("Email: " + email);

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    foreach (var item in items)
                    {
                        // Insert into Orders WITH EMAIL
                        string insertQuery = @"INSERT INTO Orders 
                    (CustomerName, CustomerEmail, CostumeId, Size, OrderDate, Status)
                    VALUES (@name, @email, @costumeId, @size, GETDATE(), 'Pending')";

                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", username);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@costumeId", item.CostumeId);
                            cmd.Parameters.AddWithValue("@size", item.CostumeSize);

                            cmd.ExecuteNonQuery();
                        }

                        // Remove item from Basket after ordering
                        string deleteQuery = "DELETE FROM Basket WHERE Id = @Id";

                        using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                        {
                            deleteCmd.Parameters.AddWithValue("@Id", item.BasketId);
                            deleteCmd.ExecuteNonQuery();
                        }
                    }
                }

                // Send confirmation email AFTER order placed
                SendConfirmationEmail(email);

                MessageBox.Show("Order placed successfully!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message);
            }
        }

        private void SendConfirmationEmail(string toEmail)
        {
            try
            {
                MailMessage mail = new MailMessage();

                mail.From = new MailAddress("fancydresshiring@gmail.com");
                mail.To.Add(toEmail);

                mail.Subject = "Order Confirmation - Fancy Dress";

                mail.Body = "Hello,\n\nYour order has been placed successfully and is currently Pending.\n\nThank you for shopping with us!";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                smtp.Credentials = new NetworkCredential(
                    "fancydresshiring@gmail.com",
                    "vkelxobsaexirwcq"
                );

                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email failed: " + ex.Message);
            }
        }
    }
}
