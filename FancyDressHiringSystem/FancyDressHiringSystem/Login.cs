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

namespace FancyDressHiringSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get the username and password from the text boxes
            string username = txtUser.Text;
            string password = SecurityHelper.HashPassword(txtPassword.Text.Trim());

            // Connection string to connect to the SQL Server database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            // Check if any fields are empty
            if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill in all fields.", "Information Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    // Create a connection to the database
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open(); // Open the connection

                        // SQL query to check if the username and password exist in the USERS table
                        string query = "SELECT COUNT(1) FROM USERS WHERE Username=@Username AND Password=@Password";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Use parameters to prevent SQL injection
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.Parameters.AddWithValue("@Password", password);

                            // Execute the query and get the count of matching records
                            int count = (int)cmd.ExecuteScalar();
                            if (count > 0)
                            {
                                if (username == "admin")
                                {
                                    Admin adminForm = new Admin();
                                    adminForm.Show();
                                    this.Hide();
                                    return;
                                }
                                else
                                {
                                    // If a matching record is found, the login is successful
                                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Mainform mainForm = new Mainform();
                                    mainForm.Show();
                                    this.Hide();
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // When the "Create an account" link is clicked, open the SignUp form and hide the Login form
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        public string Username
        {
            get { return txtUser.Text; }
        }
    }
}
