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
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Home home = new Home();
            LoadControl(home);
            UpdateBasketCount();
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

        private void btnLikes_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Likes likes = new Likes();
            LoadControl(likes);
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

                Login login = new Login();
                string username = login.Username;

                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@name", username);
                    
                    int count = (int)cmd.ExecuteScalar();

                    lblCount.Text = count.ToString();
                }
            }
        }
    }
}
