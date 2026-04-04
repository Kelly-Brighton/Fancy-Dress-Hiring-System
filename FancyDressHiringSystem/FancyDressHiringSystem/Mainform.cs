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
    public partial class Mainform : Form
    {
        private string username;

        public Mainform(string userName)
        {
            InitializeComponent();
            username = userName;
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Home home = new Home();
            LoadControl(home);
            UpdateBasketCount();
            UpdateOrdersCount();
            UpdateLikesCount();
        }

        private void LoadControl(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Home home = new Home();
            LoadControl(home);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Orders orders = new Orders();
            LoadControl(orders);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        public void UpdateBasketCount()
        {
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Basket WHERE CustomerName = @name";

                string username = Login.LoggedInUser;

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", username);

                    int count = (int)cmd.ExecuteScalar();

                    lblBasket.Text = count.ToString();
                }
            }
        }

        public void UpdateLikesCount()
        {
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Likes WHERE CustomerName = @name";

                string username = Login.LoggedInUser;
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", username);
                    int count = (int)cmd.ExecuteScalar();
                    lblLiked.Text = count.ToString();
                }
            }
        }

        public void UpdateOrdersCount()
        {
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Orders WHERE CustomerName = @name";
                string username = Login.LoggedInUser;
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", username);
                    int count = (int)cmd.ExecuteScalar();
                    lblOrders.Text = count.ToString();
                }
            }
        }

        private void btnLiked_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Likes likes = new Likes();
            LoadControl(likes);
        }

        private void btnBasket_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            lblTotal basket = new lblTotal();
            LoadControl(basket);
        }
    }
}
