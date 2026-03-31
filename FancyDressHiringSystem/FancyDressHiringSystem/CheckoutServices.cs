using System;
using System.IO;

namespace FancyDressHiringSystem
{
    public class CheckoutService
    {
        public bool ValidateOrder(Order order, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(order.CustomerName))
            {
                errorMessage = "Please enter your name.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(order.Email) || !order.Email.Contains("@"))
            {
                errorMessage = "Please enter a valid email address.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(order.Address))
            {
                errorMessage = "Please enter your address.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(order.CardNumber))
            {
                errorMessage = "Please enter your card number.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(order.ExpiryDate))
            {
                errorMessage = "Please enter card expiry date.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(order.CVV))
            {
                errorMessage = "Please enter CVV.";
                return false;
            }

            if (order.Items == null || order.Items.Count == 0)
            {
                errorMessage = "Your basket is empty.";
                return false;
            }

            errorMessage = "";
            return true;
        }

        public void SaveOrder(Order order)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Orders");
            Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, $"Order_{DateTime.Now:yyyyMMddHHmmss}.txt");

            string orderDetails =
                $"Customer Name: {order.CustomerName}{Environment.NewLine}" +
                $"Email: {order.Email}{Environment.NewLine}" +
                $"Address: {order.Address}{Environment.NewLine}" +
                $"Card Number: ****{order.CardNumber.Substring(order.CardNumber.Length - 4)}{Environment.NewLine}" +
                $"Expiry Date: {order.ExpiryDate}{Environment.NewLine}" +
                $"Items: {string.Join(", ", order.Items)}{Environment.NewLine}" +
                $"Total Price: £{order.TotalPrice:F2}{Environment.NewLine}" +
                $"Order Date: {order.OrderDate}{Environment.NewLine}";

            File.WriteAllText(filePath, orderDetails);
        }
    }
}