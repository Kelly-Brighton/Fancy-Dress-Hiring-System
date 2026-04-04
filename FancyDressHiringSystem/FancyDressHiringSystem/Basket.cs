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
    public partial class lblTotal : UserControl
    {
        public lblTotal()
        {
            InitializeComponent();
            LoadBasket();

        }

        private void flowBasket_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadBasket()
        {
            flowBasket.Controls.Clear();

            // Connection string to connect to the SQL Server database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            string username = Login.LoggedInUser; // Get the logged-in user's username

            try
            {
                // Connect to the database and retrieve the basket items for the logged-in user
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // SQL query to get the basket items for the logged-in user
                    string query = @"SELECT Basket.Id, Basket.CostumeId, Clothes.Name, Clothes.Price, Clothes.Gender, Basket.Size, Basket.Quantity, Clothes.ImagePath
                    FROM Basket
                    JOIN Clothes ON Basket.CostumeId = Clothes.Id
                    WHERE Basket.CustomerName = @name";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                BasketCard card = new BasketCard();
                                card.BasketId = Convert.ToInt32(reader["Id"]);
                                card.CostumeId = Convert.ToInt32(reader["CostumeId"]);
                                card.CostumeName = reader["Name"].ToString();
                                card.CostumePrice = reader["Price"].ToString();
                                card.CostumeSize = reader["Size"].ToString();
                                card.Quantity = Convert.ToInt32(reader["Quantity"]);
                                card.CostumeGender = reader["Gender"].ToString();

                                string imagePath = Path.Combine(Application.StartupPath, reader["ImagePath"].ToString());

                                // Check if the image file exists before trying to load it
                                if (File.Exists(imagePath))
                                {
                                    using (var img = Image.FromFile(imagePath))
                                    {
                                        card.CostumeImage = new Bitmap(img);
                                    }
                                }

                                flowBasket.Controls.Add(card);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading basket: " + ex.Message);
            }
        }

        public List<BasketCard> GetSelectedItems()
        {
            List<BasketCard> selectedItems = new List<BasketCard>();

            foreach (Control control in flowBasket.Controls)
            {
                if (control is BasketCard card && card.IsSelected)
                {
                    selectedItems.Add(card);
                }
            }
            return selectedItems;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            List<BasketCard> selectedItems = GetSelectedItems();

            // Check if any items are selected
            if (selectedItems.Count == 0)
            {
                // Proceed to checkout with the selected items
                selectedItems = flowBasket.Controls.OfType<BasketCard>().ToList();
            }

            if (selectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one item to checkout.");
                return;
            }

            CheckOut checkoutForm = new CheckOut(selectedItems);
            checkoutForm.Show();
        }

        private void lblTotal_Load(object sender, EventArgs e)
        {

        }
    }
}
