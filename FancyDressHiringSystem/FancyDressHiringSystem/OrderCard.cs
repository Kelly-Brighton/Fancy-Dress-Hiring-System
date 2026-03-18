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
    public partial class OrderCard : UserControl
    {
        public OrderCard()
        {
            InitializeComponent();
            this.Margin = new Padding(10);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            var confirm = MessageBox.Show("Are you sure you want to cancel the order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                string query = "DELETE FROM Orders WHERE Id = @Id";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", OrderId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Order " + OrderId + " has been deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Parent.Controls.Remove(this);
            }

        }

        public int OrderId { get; set; }

        public DateTime orderDate;
        public DateTime OrderDate
        {
            get { return orderDate; }
            set 
            { 
                orderDate = value;
                lblOrderDate.Text = value.ToString("dd MMM yyyy"); 
            }
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

        private DateTime dueDate;

        public DateTime DueDate
        {
            get { return dueDate; }
            set 
            { 
                dueDate = value;
                lblOrderDueDate.Text = value.ToString(); 
            }
        }
    }
}
