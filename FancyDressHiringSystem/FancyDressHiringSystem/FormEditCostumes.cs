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
    public partial class FormEditCostumes : Form
    {
        int costumeId;
        public FormEditCostumes(int id)
        {
            InitializeComponent();
            costumeId = id;
            LoadCostumeData();
        }

        private void FormEditCostumes_Load(object sender, EventArgs e)
        {

        }


        public void LoadCostumeData()
        {
            // Connection string to connect to the SQL Server database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            // Create a connection to the database
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Open the connection
                conn.Open();

                // SQL query to select the costume details based on the costume ID
                string query = "SELECT Name, Price FROM Costumes WHERE Id = @Id";

                // Create a SQL command to execute the query
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add the costume ID as a parameter to the query
                    cmd.Parameters.AddWithValue("@Id", costumeId);
                    cmd.ExecuteNonQuery();

                    // Execute the query and read the results
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // If a costume is found, populate the text boxes with the costume details
                        if (reader.Read())
                        {
                            // Populate the text boxes with the costume details
                            txtName.Text = reader["Name"].ToString();
                            txtPrice.Text = reader["Price"].ToString();
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "UPDATE Costumes SET Name = @Name, Price = @Price WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@Id", costumeId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Costume details updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Show the Admin form
            Form adminForm = new Admin();
            adminForm.Show();

            // Close the edit form
            this.Close();
        }
    }
}
