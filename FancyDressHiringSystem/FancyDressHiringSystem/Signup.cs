using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace FancyDressHiringSystem
{
    public partial class btnSignUp : Form
    {
        public btnSignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Regular expression pattern for validating email addresses
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            string email = txtEmail.Text;

            // Validate the email address using the regular expression
            if (Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Valid email address.");
            }
            else
            {
                MessageBox.Show("Invalid email address. Try again");
                return;
            }

            // Connection string to connect to the SQL Server database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            // Check if any of the fields are empty
            if (txtUser.Text == "" || txtPassword.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please fill in all fields.", "Information Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    using(SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();
                        // Check if the email already exists in the database
                        string checkEmailQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                        using (SqlCommand checkCmd = new SqlCommand(checkEmailQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@Email", txtUser.Text);
                            int count = (int)checkCmd.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("This email is already registered. Please use a different email.", "Information Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        // Insert the new user into the database
                        string insertQuery = "INSERT INTO Users (Username, Email, Password) VALUES (@Username, @Email, @Password)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", txtUser.Text);
                            cmd.Parameters.AddWithValue("@Email", txtUser.Text);
                            string hashedPassword = HashPassword(txtPassword.Text);
                            cmd.Parameters.AddWithValue("@Password", hashedPassword);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            // Check if the insertion was successful
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Registration successful!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Close the current form and open the login form
                                this.Close();
                                Login login = new Login();
                                login.Show();
                            }
                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
