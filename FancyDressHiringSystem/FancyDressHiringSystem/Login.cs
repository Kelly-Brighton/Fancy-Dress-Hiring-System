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
        public static string LoggedInUser;
        public static string UserEmail;

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
            // Get user input
            string username = txtUser.Text.Trim();
            string password = SecurityHelper.HashPassword(txtPassword.Text.Trim());

            // Connection string
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            // Validate input
            if (username == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Get BOTH username + email
                    string query = "SELECT Username, Email FROM USERS WHERE Username=@Username AND Password=@Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                LoggedInUser = reader["Username"].ToString();
                                UserEmail = reader["Email"].ToString();

                                // Admin check
                                if (LoggedInUser == "admin")
                                {
                                    MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Admin adminForm = new Admin();
                                    adminForm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Mainform mainForm = new Mainform(LoggedInUser);
                                    mainForm.Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
