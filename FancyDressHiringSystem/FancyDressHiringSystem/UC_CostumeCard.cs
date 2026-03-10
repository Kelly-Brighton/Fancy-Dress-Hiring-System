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
    public partial class UC_CostumeCard : UserControl
    {
        public UC_CostumeCard()
        {
            InitializeComponent();
            this.Margin = new Padding(15);
        }

        private void UC_CostumeCard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Connection string to connect to the SQL Server database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            // Show a confirmation dialog before deleting the costume
            var confirm = MessageBox.Show("Are you sure you want to delete this costume?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user confirms, delete the costume from the database
            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "DELETE FROM Costumes WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", CostumeID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(CostumeName + " has been deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Parent.Controls.Remove(this); // Remove the costume card from the parent control
            }
            else
            {   // If the user cancels, do nothing
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Open the edit form and pass the costumeID to it
            FormEditCostumes form = new FormEditCostumes(CostumeID);
            form.ShowDialog();

            new UC_Inventory().LoadClothes(); // Refresh the inventory after editing
        }

        // / Properties to set the costume details
        public int CostumeID { get; set; }

        public string CostumeName
        {
            get { return lblCostumeName.Text; }
            set { lblCostumeName.Text = value; }
        }

        public string Price
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public Image CostumeImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
    }
}
