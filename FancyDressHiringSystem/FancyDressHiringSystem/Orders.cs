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
            flowOrders.Controls.Clear();
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT Orders.Id, Orders.OrderDate, Ordeers.Status, Clothes.ImagePath FROM Orders" +
                    " JOIN Clothes ON Orders.CostumeId = Clothes.Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderCard orderCard = new OrderCard();
                            orderCard.OrderId = Convert.ToInt32(reader["Id"]);
                            orderCard.OrderDate = (DateTime)reader["OrderDate"];
                            orderCard.Status = reader["Status"].ToString();
                            DateTime dueDate = orderCard.OrderDate.AddDays(10);
                            orderCard.DueDate = dueDate;

                            string imagePath = Path.Combine(Application.StartupPath, reader["imagePath"].ToString());

                            if (File.Exists(imagePath))
                            {
                                orderCard.CostumeImage = Image.FromFile(imagePath);
                            }

                            flowOrders.Controls.Add(orderCard);
                        }
                    }
                }
            }

        }
            
    }
}
