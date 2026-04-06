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
    public partial class LikesCard : UserControl
    {
        public LikesCard()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the quantity from the numeric up-down control
            int quantity = (int)numericQuantity.Value;

            // Get the current customer's name
            string customerName = Login.LoggedInUser;

            // Connection string for the database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // SQL query to check if the selected cloth is already in the cart for the current customer
                    string query = "SELECT COUNT(*) FROM Basket WHERE CostumeId = @costumeId AND CustomerName = @name";

                    // Create a SqlCommand to execute the query
                    using (SqlCommand checkCmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        checkCmd.Parameters.AddWithValue("@costumeId", ClothID);
                        checkCmd.Parameters.AddWithValue("@name", customerName);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("This item is already in your cart.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            using (SqlCommand insertCmd = new SqlCommand("INSERT INTO Basket (CustomerName, CostumeId, Size, Quantity) VALUES (@name, @costumeId, @size, @quantity)", conn))
                            {
                                // Add parameters to prevent SQL injection
                                insertCmd.Parameters.AddWithValue("@name", customerName);
                                insertCmd.Parameters.AddWithValue("@costumeId", ClothID);
                                insertCmd.Parameters.AddWithValue("@size", ClothSize);
                                insertCmd.Parameters.AddWithValue("@quantity", quantity);
                                int rowsAffected = insertCmd.ExecuteNonQuery();

                                // Check if the insert was successful
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Item added to cart successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                // Update the basket count in the main form
                                Mainform main = this.FindForm() as Mainform;
                                if (main != null)
                                {
                                    main.UpdateBasketCount();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);

            }
            
        }

        // Properties to set the clothes details
        public int ClothID
        {
            set; get;
        }

        public string ClothName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string ClothPrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public Image ClothImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string ClothGender
        {
            get { return lblGender.Text; }
            set { lblGender.Text = value; }
        }

        public string ClothSize
        {
            get { return lblSize.Text; }
            set { lblSize.Text = value; }
        }
    }
}
