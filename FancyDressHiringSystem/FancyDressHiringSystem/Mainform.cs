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
    }
}
