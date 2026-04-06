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
    public partial class AIPage : UserControl
    {
        public AIPage()
        {
            InitializeComponent();
            txtAI.Text = "Enter Enquiry";
            txtAI.ForeColor = Color.Gray;
        }

        private async void btnAskAI_Click(object sender, EventArgs e)
        {
            if (txtAI.Text == "Enter Enquiry" || string.IsNullOrWhiteSpace(txtAI.Text))
            {
                MessageBox.Show("Please enter a valid enquiry.");
                return;
            }

            AIAgent agent = new AIAgent();

            string userInput = txtAI.Text;

            string extractPrompt = $@"
User request: '{userInput}'

Extract:
- Gender (Male, Women, Unisex)
- MaxPrice (number)

Respond ONLY like this:
Gender: ___
MaxPrice: ___
";

            string aiAnalysis = await agent.AskAI(extractPrompt);

            richAIResponse.AppendText("AI Analysis:\n" + aiAnalysis + "\n\n");

            string gender = "";
            decimal maxPrice = 1000;

            if (aiAnalysis.Contains("Male")) gender = "Male";
            else if (aiAnalysis.Contains("Women")) gender = "Women";
            else if (aiAnalysis.Contains("Unisex")) gender = "Unisex";

            var match = System.Text.RegularExpressions.Regex.Match(aiAnalysis, @"\d+");
            if (match.Success)
                maxPrice = decimal.Parse(match.Value);

            LoadAIResults(gender, maxPrice);

            string explainPrompt = $@"
The user asked: '{userInput}'

Explain in a friendly way what kind of costumes they should consider.
Keep it short and engaging.";

            string aiMessage = await agent.AskAI(explainPrompt);

            richAIResponse.AppendText("AI Suggestion:\n" + aiMessage + "\n\n");
        }

        public void LoadAIResults(string gender, decimal maxPrice)
        {
            flowAIResults.Controls.Clear(); // clear previous results

            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT * FROM Clothes WHERE Price <= @price";

                // Add gender filter if provided
                if (!string.IsNullOrEmpty(gender))
                {
                    query += " AND Gender = @gender";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@price", maxPrice);

                    if (!string.IsNullOrEmpty(gender))
                    {
                        cmd.Parameters.AddWithValue("@gender", gender);
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClothCard card = new ClothCard();

                            card.ClothID = Convert.ToInt32(reader["Id"]);
                            card.ClothName = reader["Name"].ToString();
                            card.ClothPrice = "£" + reader["Price"].ToString();
                            card.ClothGender = reader["Gender"].ToString();
                            card.ClothSize = reader["Size"].ToString();

                            string imagePath = reader["ImagePath"].ToString();

                            if (File.Exists(imagePath))
                            {
                                using (var img = Image.FromFile(imagePath))
                                {
                                    card.ClothImage = new Bitmap(img);
                                }
                            }

                            flowAIResults.Controls.Add(card);
                        }
                    }
                }
            }
        }

        private void txtAI_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAI_Enter(object sender, EventArgs e)
        {
            if (txtAI.Text == "Enter Enquiry")
            {
                txtAI.Text = "";
                txtAI.ForeColor = Color.Black;
            }
        }

        private void txtAI_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAI.Text))
            {
                txtAI.Text = "Enter Enquiry";
                txtAI.ForeColor = Color.Gray;
            }
        }
    }
}
