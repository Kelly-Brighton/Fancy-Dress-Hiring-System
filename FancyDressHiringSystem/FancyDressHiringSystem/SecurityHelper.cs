using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;   // For SHA256

namespace FancyDressHiringSystem
{
    public static class SecurityHelper
    {
        public static string HashPassword(string password)  // Static method
        {
            using (SHA256 sha256 = SHA256.Create())        // Create SHA256 instance
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password)); // Hash bytes

                StringBuilder builder = new StringBuilder(); // Store result

                foreach (byte b in bytes)                   // Convert each byte
                {
                    builder.Append(b.ToString("x2"));       // Convert to hex
                }

                return builder.ToString();                  // Return hashed string
            }
        }
    }
}
