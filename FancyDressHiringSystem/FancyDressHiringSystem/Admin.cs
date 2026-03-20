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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UC_Inventory inventory = new UC_Inventory();
            LoadControl(inventory);
        }

        private void LoadControl(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_Inventory());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_Orders());
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_Upload());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
