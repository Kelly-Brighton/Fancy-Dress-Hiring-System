using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
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
            LoadClothesWithFilters(); // Load clothes with the updated search term

            // I want to delete the search label when the user starts typing in the search box, but I also want to show it again when the search box is empty
            lblSearch.Text = string.IsNullOrEmpty(txtSearch.Text) ? "Search for clothes..." : ""; // Show the search label when the search box is empty, otherwise hide it
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

        private void label10_Click(object sender, EventArgs e)
        {
        }

        public void LoadClothesWithFilters()
        {
            flowHome.Controls.Clear();

            string searchTerm = txtSearch.Text.Trim();

            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // Collect filters
                List<string> genders = new List<string>();
                List<string> sizes = new List<string>();

                if (chkboxMen.Checked) genders.Add("Male");
                if (chkboxWomen.Checked) genders.Add("Women");
                if (chkboxUnisex.Checked) genders.Add("Unisex");

                if (chkboxS.Checked) sizes.Add("S");
                if (chkboxM.Checked) sizes.Add("M");
                if (chkboxL.Checked) sizes.Add("L");
                if (chkboxXS.Checked) sizes.Add("XS");
                if (chkboxXL.Checked) sizes.Add("XL");
                if (chkboxXXL.Checked) sizes.Add("XXL");

                // Build query ONLY using helper
                string query = FilterHelper.BuildQuery(
                    genders,
                    sizes,
                    !string.IsNullOrEmpty(searchTerm)
                );

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters BEFORE execution
                    cmd.Parameters.AddWithValue("@price", trackPrice.Value);

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    }

                    bool hasResults = false;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hasResults = true;

                            ClothCard card = new ClothCard();
                            card.ClothID = Convert.ToInt32(reader["Id"]);
                            card.ClothName = reader["Name"].ToString();
                            card.ClothPrice = "£" + reader["Price"].ToString();

                            string imagePath = reader["ImagePath"].ToString();

                            if (File.Exists(imagePath))
                            {
                                using (var img = Image.FromFile(imagePath))
                                {
                                    card.ClothImage = new Bitmap(img);
                                }
                            }

                            card.ClothGender = reader["Gender"].ToString();
                            card.ClothSize = reader["Size"].ToString();

                            flowHome.Controls.Add(card);
                        }
                    }

                    // No results message
                    if (!hasResults)
                    {
                        Label lblNoResults = new Label();
                        lblNoResults.Text = "No clothes found matching the selected filters.";
                        lblNoResults.AutoSize = true;
                        lblNoResults.Font = new Font("Arial", 14, FontStyle.Bold);
                        lblNoResults.ForeColor = Color.Red;
                        lblNoResults.TextAlign = ContentAlignment.MiddleCenter;
                        lblNoResults.Padding = new Padding(20);

                        flowHome.Controls.Add(lblNoResults);

                        timerNoResults.Start();
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
