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
            LoadLikes();
        }
        // When the Likes page loads, call the method to load liked items
        private void Likes_Load(object sender, EventArgs e)
        {
            LoadLikes();
        }

        public void LoadLikes()
        {
            // Clear existing controls before displaying search results
            flowLikes.Controls.Clear();

            // Connection string for the database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            // Get the current logged-in user's username
            string username = Login.LoggedInUser;

            // Create and open a connection to the database
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // SQL query to retrieve liked items for the current user
                // Joins Likes table with Clothes table to get full item details
                string query = @"SELECT Likes.Id, Likes.CostumeId, Likes.Size, Clothes.Price, Clothes.Name, Clothes.Gender, Clothes.ImagePath 
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
                            LikesCard card = new LikesCard();
                            card.ClothID = Convert.ToInt32(reader["CostumeId"]);
                            card.ClothName = reader["Name"].ToString();
                            card.ClothPrice = reader["Price"].ToString();
                            card.ClothGender = reader["Gender"].ToString();
                            card.ClothSize = reader["Size"].ToString();

                            string imagePath = Path.Combine(Application.StartupPath, reader["ImagePath"].ToString());

                            // Check if the image file exists before trying to load it
                            if (File.Exists(imagePath))
                            {
                                using (var img = Image.FromFile(imagePath))
                                {
                                    card.ClothImage = new Bitmap(img);
                                }
                            }

                            flowLikes.Controls.Add(card);
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
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}