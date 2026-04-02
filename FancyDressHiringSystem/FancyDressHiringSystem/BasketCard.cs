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
    public partial class BasketCard : UserControl
    {
        public BasketCard()
        {
            InitializeComponent();
            this.Margin = new Padding(15);
            
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Connection string for the database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            // Show a confirmation dialog before deleting the item from the cart
            var confirm = MessageBox.Show("Are you sure you want to remove this item from your cart?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user confirms, delete the item from the cart in the database
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // SQL query to delete the item from the cart in the database
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();

                        string query = "DELETE FROM Basket WHERE Id = @Id"; // SQL query to delete the item from the cart in the database

                        // Create a SqlCommand to execute the query
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", BasketId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Show a success message and remove the item card from the parent control
                    MessageBox.Show("Item has been removed from your cart.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Parent?.Controls.Remove(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while trying to remove the item from the cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to update the shipping label based on the costume price
        public void UpdateShippingLabel()
        {
            // Get the costume price as a string and try to parse it to an integer
            string input = CostumePrice;
            int number;

            // If the parsing is successful, check if the price is greater than 35 to determine the shipping cost
            if (int.TryParse(input, out number))
            {
                if (number > 35)
                {
                    lblShipping.Text = "Free Shipping";
                }
                else
                {
                    lblShipping.Text = "Shipping: £5.00";
                }
            }
            else
            {
                lblShipping.Text = "Invalid price format.";
            }
        }

        public int BasketId { get; set; } // Property to hold the basket item ID, used for deletion from the database

        public string CostumeName // Property to get and set the costume name
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string CostumeGender // Property to get and set the costume
        {
            get { return lblGender.Text; }
            set { lblGender.Text = value; }
        }

        public string CostumeSize // Property to get and set the costume size
        {
            get { return lblSize.Text; }
            set { lblSize.Text = value; }
        }

        public string CostumePrice //  Property to get and set the costume price
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; UpdateShippingLabel(); }
        }

        public Image CostumeImage // Property to get and set the costume image
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public int Quantity // Property to get and set the quantity of the costume
        {
            get { return (int)numericCount.Value; }
            set { numericCount.Value = value; }
        }


    }
}
