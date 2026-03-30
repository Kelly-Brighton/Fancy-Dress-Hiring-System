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
            this.Margin = new Padding(10); // Add margin to the control
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Connection string for the database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            // Show a confirmation dialog before deleting the order
            var confirm = MessageBox.Show("Are you sure you want to cancel the order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user confirms, delete the order from the database
            if (confirm == DialogResult.Yes)
            {
                // SQL query to delete the order from the database
                string query = "DELETE FROM Orders WHERE Id = @Id";

                // Create a connection to the database and execute the query
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open(); // Open the connection

                    // Create a SqlCommand to execute the query
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", OrderId); // Add the order ID as a parameter to prevent SQL injection

                        cmd.ExecuteNonQuery();// Execute the query to delete the order
                    }
                }

                MessageBox.Show("Order " + OrderId + " has been deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show a message box to inform the user that the order has been deleted
                this.Parent?.Controls.Remove(this);// Remove the order card from the parent control
            }

        }

        // Property to hold the order ID
        public int OrderId { get; set; }

        public DateTime orderDate; // Backing field for the OrderDate property
        public DateTime OrderDate // Property to get and set the order date
        {
            get { return orderDate; }
            set
            {
                orderDate = value;
                lblOrderDate.Text = value.ToString("dd MMM yyyy");
            }
        }

        public string CostumeName // Property to get and set the costume name
        {
            get { return lblCostumeName.Text; }
            set { lblCostumeName.Text = value; }
        }

        public string Status // Property to get and set the order status
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }
        public Image CostumeImage // Property to get and set the costume image
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        private DateTime dueDate; // Backing field for the DueDate property

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OrderCard_Load(object sender, EventArgs e)
        {

        }

        public DateTime DueDate // Property to get and set the due date
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
