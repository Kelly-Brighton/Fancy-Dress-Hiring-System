using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.IO;

namespace FancyDressHiringSystem
{
    public partial class UC_Inventory : UserControl
    {
        public UC_Inventory()
        {
            InitializeComponent();
            LoadClothes();
        }


        private void UC_Inventory_Load(object sender, EventArgs e)
        {

        }


        private void flowLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadClothes()
        {
            flowInventory.Controls.Clear();

            // Connection string to connect to the SQL Server database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            // Create a connection to the database
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT Id, Name, Price, ImagePath FROM Clothes";

                // Create a SQL command to execute the query
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Execute the query and read the results
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a new costume card for each costume in the database
                            UC_CostumeCard card = new UC_CostumeCard();
                            card.CostumeID = Convert.ToInt32(reader["Id"]);
                            card.CostumeName = reader["Name"].ToString();
                            card.Price = "£" + reader["Price"].ToString();
                            string imagePath = Path.Combine(Application.StartupPath, reader["ImagePath"].ToString());

                            // Load the image from the file path if it exists
                            if (File.Exists(imagePath))
                            {
                                using (var img = Image.FromFile(imagePath))
                                {
                                    card.CostumeImage = new Bitmap(img);
                                }
                            }
                            // Add the costume card to the flow layout panel
                            flowInventory.Controls.Add(card);
                        }
                    }
                }
            }
        }
    }
}
