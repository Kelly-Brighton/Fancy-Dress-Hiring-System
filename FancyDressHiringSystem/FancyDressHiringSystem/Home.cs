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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FancyDressHiringSystem
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            LoadClothes();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            // Clear the search label when the user starts typing in the search box
            lblSearch.Text = "";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public void LoadClothes()
        {
            flowHome.Controls.Clear();

            // Connection string for the database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            // Create a connection to the database
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open(); // Open the connection

                string query = "SELECT Id, Name, Price, ImagePath FROM Clothes"; // SQL query to retrieve cloth data

                // Execute the query and read the data
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Use a SqlDataReader to read the data from the database
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a new cloth card for each cloth in the database
                            ClothCard card = new ClothCard();
                            card.ClothID = Convert.ToInt32(reader["Id"]);
                            card.ClothName = reader["Name"].ToString();
                            card.ClothPrice = "£" + reader["Price"].ToString();
                            string imagePath = reader["ImagePath"].ToString();

                            // Load the image from the file path and set it to the picture box
                            if (File.Exists(imagePath))
                            {
                                card.ClothImage = Image.FromFile(imagePath);
                            }
                            card.ClothGender = reader["Gender"].ToString();
                            card.ClothSize = reader["Size"].ToString();

                            flowHome.Controls.Add(card); // Add the cloth card to the flow layout panel
                        }
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            flowHome.Controls.Clear(); // Clear existing controls before displaying search results

            // Connection string for the database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            // Create a connection to the database
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string searchTerm = txtSearch.Text.Trim(); // Get the search term from the text box

                // SQL query to search for clothes based on the search term
                string query = "SELECT Id, Name, Price, ImagePath FROM Clothes WHERE Name = @searchTerm";

                // Execute the query and read the data
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Use parameterized query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@searchTerm", searchTerm);

                    // Use a SqlDataReader to read the data from the database
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if any results were found
                        while (reader.Read())
                        {
                            // Create a new cloth card for each cloth in the search results
                            ClothCard card = new ClothCard();
                            card.ClothID = Convert.ToInt32(reader["Id"]);
                            card.ClothName = reader["Name"].ToString();
                            card.ClothPrice = "£" + reader["Price"].ToString();
                            string imagePath = reader["ImagePath"].ToString();
                            if (File.Exists(imagePath))
                            {
                                card.ClothImage = Image.FromFile(imagePath);
                            }
                            card.ClothGender = reader["Gender"].ToString();
                            card.ClothSize = reader["Size"].ToString();

                            flowHome.Controls.Add(card); // Add the cloth card to the flow layout panel
                        }
                    }
                }
            }
        }
    }
}
