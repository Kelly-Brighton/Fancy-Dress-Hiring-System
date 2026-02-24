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

            string email = txtUser.Text;

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
            if (txtUser.Text == "" || txtPassword.Text == "" || txtConfirm.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
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
                                MessageBox.Show("This email is already registered. Please use a different email.");
                                return;
                            }
                        }
                        // Insert the new user into the database
                        string insertQuery = "INSERT INTO Users (Email, Password) VALUES (@Email, @Password)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", txtUser.Text);
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Registration successful!");

                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }



        }
    }
}
