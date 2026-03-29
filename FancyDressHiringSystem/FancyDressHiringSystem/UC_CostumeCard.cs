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
                string checkOrders = "SELECT COUNT(*) FROM Orders WHERE CostumeId = @CostumeId";

                // Check if there are any orders associated with this costume before deleting
                using (SqlCommand checkCmd = new SqlCommand(checkOrders, new SqlConnection(connString)))
                {
                    checkCmd.Parameters.AddWithValue("@CostumeId", CostumeID);
                    checkCmd.Connection.Open();
                    int orderCount = (int)checkCmd.ExecuteScalar();
                    checkCmd.Connection.Close();
                    if (orderCount > 0) // If there are orders associated with this costume, show an error message and do not delete
                    {
                        MessageBox.Show("Cannot delete this costume because it is associated with existing orders.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else // If there are no orders associated with this costume, proceed to delete it from the database
                    {
                        // Create a connection to the database and delete the costume
                        using (SqlConnection conn = new SqlConnection(connString))
                        {
                            conn.Open();
                            string query = "DELETE FROM Clothes WHERE Id = @Id";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Id", CostumeID);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        // Show a success message and remove the costume card from the parent control
                        MessageBox.Show(CostumeName + " has been deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Parent?.Controls.Remove(this); // Remove the costume card from the parent control
                    }
                }
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
        }

        // / Properties to set the costume details
        public int CostumeID { get; set; }

        public string CostumeName
        {
            get { return lblClothName.Text; }
            set { lblClothName.Text = value; }
        }

        public string Price
        {
            get { return lblClothPrice.Text; }
            set { lblClothPrice.Text = value; }
        }

        public Image CostumeImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
    }
}
