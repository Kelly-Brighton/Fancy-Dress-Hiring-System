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

namespace FancyDressHiringSystem
{
    public partial class Likes : UserControl
    {
        public Likes()
        {
            InitializeComponent();
        }
        // When the Likes page loads, call the method to load liked items
        private void Likes_Load(object sender, EventArgs e)
        {
            LoadLikes();
        }

        public void LoadLikes()
        {
            // Clear existing controls before displaying search results
            flowLayoutPanel1.Controls.Clear();
            // Connection string for the database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            // Get the current logged-in user's username
            string username = "testuser";

            // Create and open a connection to the database
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // SQL query to retrieve liked items for the current user
                // Joins Likes table with Clothes table to get full item details
                string query = @"SELECT Clothes.Id, Clothes.Name, Clothes.ImagePath 
                         FROM Likes 
                         JOIN Clothes ON Likes.CostumeId = Clothes.Id
                         WHERE Likes.CustomerName = @name";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Adds parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@name", username);

                    // Execute the query and read the results
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Loop through each record returned from the database
                        while (reader.Read())
                        {
                            // Create a new LikeCard for each liked item
                            LikeCard card = new LikeCard();
                            // Set the card properties using database values
                            card.CostumeID = Convert.ToInt32(reader["Id"]);
                            card.CostumeName = reader["Name"].ToString();
                            // Get the image path and check if the file exists
                            string imagePath = reader["ImagePath"].ToString();

                            // Combines with app path
                            string fullPath = Path.Combine(Application.StartupPath, imagePath);

                            // Check if file exists before loading
                            if (File.Exists(fullPath))
                            {
                                card.CostumeImage = Image.FromFile(fullPath);
                            }
                            // Add the card to the FlowLayoutPanel
                            flowLayoutPanel1.Controls.Add(card);
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Back button
        private void button1_Click(object sender, EventArgs e)
        {
            // Get reference to the Mainform
            Mainform main = this.FindForm() as Mainform;
            // If Mainform exists, call method to show Home page
            if (main != null)
            {
                main.LoadControl(new Home());
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}