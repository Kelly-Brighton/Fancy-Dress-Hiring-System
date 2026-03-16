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
    public partial class OrderCard : UserControl
    {
        public OrderCard()
        {
            InitializeComponent();
            this.Margin = new Padding(10);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        public int OrderId { get; set; }

        public DateTime OrderDate
        { 
            get { return Convert.ToDateTime(lblOrderDate.Text); } 
            set {  lblOrderDate.Text = value.ToString(); }
        }

        public string Status
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }
        public Image CostumeImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
    }
}
