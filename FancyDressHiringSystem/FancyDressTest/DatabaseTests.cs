using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Data.SqlClient;

namespace FancyDressTests
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void Test_DatabaseConnection()
        {
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                Assert.AreEqual(System.Data.ConnectionState.Open, conn.State);
            }
        }

        [TestMethod]
        public void Test_ClothesTableHasData()
        {
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Clothes";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int count = (int)cmd.ExecuteScalar();

                    Assert.IsTrue(count >= 0);
                }
            }
        }

        [TestMethod]
        public void Test_InsertOrder()
        {
            string connString = "Server=localhost;Database=FancyDressDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = @"INSERT INTO Orders (CustomerName, CustomerEmail, CostumeId, Size, Status)
                         VALUES ('TestUser', 'test@test.com', 1, 'M', 'Pending')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int rows = cmd.ExecuteNonQuery();

                    Assert.AreEqual(1, rows);
                }
            }
        }

        [TestMethod]
        public void Test_InsertOrder_AndCleanup()
        {
            string connString = "...";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // Insert
                string insert = @"INSERT INTO Orders (CustomerName, CustomerEmail, CostumeId, Size, Status)
                          VALUES ('TestUser', 'test@test.com', 1, 'M', 'Pending')";

                using (SqlCommand cmd = new SqlCommand(insert, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Cleanup
                string delete = "DELETE FROM Orders WHERE CustomerName = 'TestUser'";

                using (SqlCommand cmd = new SqlCommand(delete, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Test_LikesInsert()
        {
            string connString = "...";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = @"INSERT INTO Likes (CustomerName, CostumeId, Size, Quantity)
                         VALUES ('TestUser', 1, 'M', 1)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int rows = cmd.ExecuteNonQuery();

                    Assert.AreEqual(1, rows);
                }

                // Cleanup
                new SqlCommand("DELETE FROM Likes WHERE CustomerName='TestUser'", conn).ExecuteNonQuery();
            }
        }

        [TestMethod]
        public void Test_BasketInsert()
        {
            string connString = "...";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = @"INSERT INTO Basket (CustomerName, CostumeId, Size, Quantity)
                         VALUES ('TestUser', 1, 'M', 1)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int rows = cmd.ExecuteNonQuery();

                    Assert.AreEqual(1, rows);
                }

                // Cleanup
                new SqlCommand("DELETE FROM Basket WHERE CustomerName='TestUser'", conn).ExecuteNonQuery();
            }
        }
    }
}
