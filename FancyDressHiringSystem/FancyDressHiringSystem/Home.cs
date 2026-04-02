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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FancyDressHiringSystem
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            LoadClothes();
            lblPrice.Text = "£" + trackPrice.Maximum.ToString(); // Set the initial price label to show the current value of the price trackbar
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            // Clear the search label when the user starts typing in the search box
            lblSearch.Text = "";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public void LoadClothes()
        {
            LoadClothesWithFilters(); // Load clothes with the default filters
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            flowHome.Controls.Clear(); // Clear existing controls before displaying search results

            // Connection string for the database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            // Create a connection to the database
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string searchTerm = txtSearch.Text.Trim(); // Get the search term from the text box

                // SQL query to search for clothes based on the search term
                string query = "SELECT Id, Name, Price, ImagePath FROM Clothes WHERE Name = @searchTerm";

                // Execute the query and read the data
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Use parameterized query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@searchTerm", searchTerm);

                    bool hasResults = false; // Flag to track if any results were found

                    // Use a SqlDataReader to read the data from the database
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if any results were found
                        while (reader.Read())
                        {
                            hasResults = true; // Set the flag to true if at least one result is found 

                            // Create a new cloth card for each cloth in the search results
                            ClothCard card = new ClothCard();
                            card.ClothID = Convert.ToInt32(reader["Id"]);
                            card.ClothName = reader["Name"].ToString();
                            card.ClothPrice = "£" + reader["Price"].ToString();
                            string imagePath = reader["ImagePath"].ToString();
                            if (File.Exists(imagePath))
                            {
                                card.ClothImage = Image.FromFile(imagePath);
                            }
                            card.ClothGender = reader["Gender"].ToString();
                            card.ClothSize = reader["Size"].ToString();

                            flowHome.Controls.Add(card); // Add the cloth card to the flow layout panel
                        }
                    }

                    if (!hasResults)
                    {
                        // Display a message if no results were found
                        Label lblNoResults = new Label();
                        lblNoResults.Text = "No clothes found matching the search term.";
                        lblNoResults.AutoSize = true;
                        lblNoResults.Font = new Font("Arial", 14, FontStyle.Bold);
                        lblNoResults.ForeColor = Color.Red;
                        lblNoResults.TextAlign = ContentAlignment.MiddleCenter;
                        lblNoResults.Padding = new Padding(20);
                        flowHome.Controls.Add(lblNoResults); // Add the label to the flow layout panel

                        timerNoResults.Start(); // Start the timer to reset the search after a short delay
                    }
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        public void LoadClothesWithFilters()
        {
            
            // Clear the flow layout panel before loading the filtered clothes
            flowHome.Controls.Clear();

            // Connection string for the database
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            //  Create a connection to the database
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open(); // Open the connection

                // SqL query to retrieve clothes based on the selected filters
                string query = "SELECT * FROM Clothes WHERE 1=1"; // Start with a base query

                // Gender filer
                List<string> genders = new List<string>();

                // Check which gender checkboxes are checked and add the corresponding genders to the list for the SQL query 
                if (chkboxMen.Checked)
                {
                    genders.Add("Male");
                }

                if (chkboxWomen.Checked)
                {
                    genders.Add("Women");
                }

                if (chkboxUnisex.Checked)
                {
                    genders.Add("Unisex");
                }

                // If any gender checkboxes are checked add the gender filter to the SQL query using the IN clause to filter by the selected genders  
                if (genders.Count > 0)
                {
                    query += " AND Gender IN (" + string.Join(",", genders.Select(g => $"'{g}'")) + ")";
                }

                // Size filter
                List<string> sizes = new List<string>();

                // Check which size checkboxes are checked and add the corresponding sizes to the list for the SQL query
                if (chkboxS.Checked)
                {
                    sizes.Add("S");
                }

                if (chkboxM.Checked)
                {
                    sizes.Add("M");
                }

                if (chkboxL.Checked)
                {
                    sizes.Add("L");
                }

                if (chkboxXS.Checked)
                {
                    sizes.Add("XS");
                }

                if (chkboxXL.Checked)
                {
                    sizes.Add("XL");
                }

                if (chkboxXXL.Checked)
                {
                    sizes.Add("XXL");
                }

                if (sizes.Count > 0)
                {
                    query += " AND Size IN (" + string.Join(query, sizes.Select(s => $"'{s}'")) + ")"; // Add size filter to the SQL query using the IN clause to filter by the selected sizes
                }

                // Price filter
                query += " AND Price <= @price"; // Add price filter to the SQL query

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add the price parameter to the SQL query
                    cmd.Parameters.AddWithValue("@price", trackPrice.Value);

                    bool hasResults = false; // Flag to track if any results were found

                    // Use a SqlDataReader to read the data from the database
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hasResults = true; // Set the flag to true if at least one result is found
                            // Create a new cloth card for each cloth in the database
                            ClothCard card = new ClothCard();
                            card.ClothID = Convert.ToInt32(reader["Id"]);
                            card.ClothName = reader["Name"].ToString();
                            card.ClothPrice = "£" + reader["Price"].ToString();
                            string imagePath = reader["ImagePath"].ToString();
                            // Load the image from the file path and set it to the picture box

                            if (File.Exists(imagePath))
                            {
                                using (var img = Image.FromFile(imagePath))
                                {
                                    card.ClothImage = new Bitmap(img);
                                }
                            }
                            card.ClothGender = reader["Gender"].ToString();
                            card.ClothSize = reader["Size"].ToString();

                            flowHome.Controls.Add(card); // Add the cloth card to the flow layout panel
                        }
                    }

                    // If no results were found, display a message to the user
                    if (!hasResults)
                    {
                        // Display a message if no results were found
                        Label lblNoResults = new Label();
                        lblNoResults.Text = "No clothes found matching the selected filters.";
                        lblNoResults.AutoSize = true;
                        lblNoResults.Font = new Font("Arial", 14, FontStyle.Bold);
                        lblNoResults.ForeColor = Color.Red;
                        lblNoResults.TextAlign = ContentAlignment.MiddleCenter;
                        lblNoResults.Padding = new Padding(20);
                        flowHome.Controls.Add(lblNoResults); // Add the label to the flow layout panel

                        timerNoResults.Start(); // Start the timer to reset the filters after a short delay
                    }
                }
            }


        }

        private void chkboxMen_CheckedChanged(object sender, EventArgs e)
        {
            LoadClothesWithFilters(); // Reload the clothes with the updated
        }

        private void chkboxWomen_CheckedChanged(object sender, EventArgs e)
        {
            LoadClothesWithFilters(); // Reload the clothes with the updated filters
        }

        private void chkboxUnisex_CheckedChanged(object sender, EventArgs e)
        {
            LoadClothesWithFilters(); // Reload the clothes with the updated filters
        }

        private void trackPrice_Scroll(object sender, EventArgs e)
        {
            lblPrice.Text = "£" + trackPrice.Value.ToString(); // Update the price label to show the current value of the price trackbar
            LoadClothesWithFilters(); // Reload the clothes with the updated filters
        }

        private void timerNoResults_Tick(object sender, EventArgs e)
        {
            timerNoResults.Stop(); // Stop the timer

            // Reset filters
            chkboxMen.Checked = false;
            chkboxWomen.Checked = false;
            chkboxUnisex.Checked = false;

            trackPrice.Value = trackPrice.Maximum; // Reset the price filter to the maximum value

            // Reload the clothes with the default filters
            LoadClothesWithFilters();
        }

        private void chkboxXS_CheckedChanged(object sender, EventArgs e)
        {
            LoadClothesWithFilters();
        }

        private void chkboxS_CheckedChanged(object sender, EventArgs e)
        {
            LoadClothesWithFilters();
        }

        private void chkboxM_CheckedChanged(object sender, EventArgs e)
        {
            LoadClothesWithFilters();
        }

        private void chkboxXL_CheckedChanged(object sender, EventArgs e)
        {
            LoadClothesWithFilters();
        }

        private void chkboxXXL_CheckedChanged(object sender, EventArgs e)
        {
            LoadClothesWithFilters();
        }

        private void chkboxL_CheckedChanged(object sender, EventArgs e)
        {
            LoadClothesWithFilters();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear the checkboxes
            chkboxMen.Checked = false;
            chkboxWomen.Checked = false;
            chkboxUnisex.Checked = false;
            chkboxM.Checked = false;
            chkboxS.Checked = false;
            chkboxL.Checked = false;
            chkboxXS.Checked = false;
            chkboxXL.Checked = false;
            chkboxXXL.Checked = false;

            // Track bar reset
            trackPrice.Value = trackPrice.Maximum; // Reset the price filter to the maximum value
            lblPrice.Text = "£" + trackPrice.Maximum.ToString();

            txtSearch.Text = ""; // Clear the search box

            LoadClothesWithFilters(); // Reload the clothes with the default filters


        }

        private void flowHome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
