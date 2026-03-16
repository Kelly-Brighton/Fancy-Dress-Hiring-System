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
    public partial class UC_Upload : UserControl
    {
        string selectedImagePath = string.Empty;
        public UC_Upload()
        {
            InitializeComponent();

            // Add gender
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Unisex");

            // Add size options to the combo box
            cmbSize.Items.Add("XS");
            cmbSize.Items.Add("S");
            cmbSize.Items.Add("M");
            cmbSize.Items.Add("L");
            cmbSize.Items.Add("XL");
            cmbSize.Items.Add("XXL");
        }

        private void UC_Upload_Load(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to allow the user to select an image file
            OpenFileDialog ofd = new OpenFileDialog();

            // Set the filter to allow only image files
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            // Show the dialog and check if the user selected a file
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picPreview.Image = Image.FromFile(ofd.FileName);
                selectedImagePath = ofd.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (txtName.Text == "" || txtPrice.Text == "" || selectedImagePath == "")
            {
                MessageBox.Show("Please fill in all fields and upload an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save the image to the "Images" folder in the application directory
            string fileName = Path.GetFileName(selectedImagePath);

            string newPath = Path.Combine(Application.StartupPath, "Images", fileName); // Ensure the "Images" directory exists

            File.Copy(selectedImagePath, newPath, true); // Copy the file to the new location, overwrite if it already exists

            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open(); // Open the connection

                string query = "INSERT INTO Clothes (Name, Price, ImagePath, Gender, Size) VALUES (@name, @price, @imagePath, @gender, @size)"; // SQL query to insert a new costume

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to the SQL command
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@imagePath", "Images/" + fileName);
                    cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@size", cmbSize.Text);

                    cmd.ExecuteNonQuery(); // Execute the command to insert the new costume into the database
                }

                MessageBox.Show("Costume added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show a success message

                ClearFields(); // Clear the input fields after saving
            }
        }

        // Method to clear the input fields after saving a costume
        private void ClearFields()
        {
            txtName.Clear();
            txtPrice.Clear();
            cmbGender.SelectedIndex = -1;
            cmbSize.SelectedIndex = -1;
            picPreview.Image = null;
            selectedImagePath = string.Empty;
        }
    }
}
