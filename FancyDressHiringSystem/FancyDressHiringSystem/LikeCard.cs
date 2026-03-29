using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FancyDressHiringSystem
{
    public partial class LikeCard : UserControl
    {
        public LikeCard()
        {
            InitializeComponent();
        }
        // Property to store the costume ID
        public int CostumeID { get; set; }

        // Property to get/set the costume name displayed on the label
        public string CostumeName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        // Property to get/set the costume image displayed in the picture box
        public Image CostumeImage
        {
            get { return picImage.Image; }
            set { picImage.Image = value; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public event EventHandler OnRemoved;

        // Like button click event
        private void btnLike_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Remove this item from likes?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // If user confirms, remove from database
            if (confirm == DialogResult.Yes)
            {
                // Connection string to connect to SQL Server database
                string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";
                // Get the current user's username
                Login login = new Login();
                string username = login.Username;

                // Create and open database connection
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    // SQL query to delete the liked item for the current user
                    string query = "DELETE FROM Likes WHERE CostumeId = @id AND CustomerName = @name";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@id", CostumeID);
                        cmd.Parameters.AddWithValue("@name", username);
                        // Execute the delete command
                        cmd.ExecuteNonQuery();
                    }
                }
                // Remove the card from the UI after deletion
                this.Parent.Controls.Remove(this);
            }
        }

        // View Details button click event
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            // Display basic information about the selected costume
            MessageBox.Show(
            "Costume: " + CostumeName,
            "Details",
             MessageBoxButtons.OK,
             MessageBoxIcon.Information);
        }

        private void picImage_Click(object sender, EventArgs e)
        {

        }
    }
}
