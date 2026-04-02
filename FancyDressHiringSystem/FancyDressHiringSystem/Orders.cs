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
    public partial class Orders : UserControl
    {
        public Orders()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void flowOrders_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadOrders()
        {
            // Clear existing order cards
            flowOrders.Controls.Clear();

            string username = Login.LoggedInUser;

            // Connection string to the database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";
            try
            {
                // Connect to the database and retrieve orders for the logged-in user   
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // SQL query to get orders along with the image path of the costume
                    string query = @"SELECT Orders.Id, Orders.OrderDate, Orders.Status, Clothes.Name, Clothes.ImagePath FROM Orders" +
                        " JOIN Clothes ON Orders.CostumeId = Clothes.Id WHERE Orders.CustomerName = @name";

                    // Execute the query and create order cards for each order
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Loop through the orders and create order cards
                            while (reader.Read())
                            {
                                OrderCard orderCard = new OrderCard();
                                orderCard.OrderId = Convert.ToInt32(reader["Id"]);
                                orderCard.OrderDate = (DateTime)reader["OrderDate"];
                                orderCard.Status = reader["Status"].ToString();
                                orderCard.CostumeName = reader["Name"].ToString();
                                DateTime dueDate = orderCard.OrderDate.AddDays(10);
                                orderCard.DueDate = dueDate;

                                string imagePath = Path.Combine(Application.StartupPath, reader["ImagePath"].ToString());

                                if (File.Exists(imagePath))
                                {
                                    using (var img = Image.FromFile(imagePath))
                                    {
                                        orderCard.CostumeImage = new Bitmap(img); 
                                    }
                                }

                                flowOrders.Controls.Add(orderCard);
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
            
    }
}
