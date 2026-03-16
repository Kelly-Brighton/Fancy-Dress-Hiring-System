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

                string query = "SELECT Id, OrderDate, Status FROM Orders";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderCard orderCard = new OrderCard();
                            orderCard.OrderId = Convert.ToInt32(reader["Id"]);
                            //orderCard.OrderDate = reader["OrderDate"].ToString();
                        }
                    }
                }
            }

        }
            
    }
}
