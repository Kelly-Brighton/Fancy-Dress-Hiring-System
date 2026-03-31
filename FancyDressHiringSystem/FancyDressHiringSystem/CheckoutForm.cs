using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FancyDressHiringSystem
{
    public partial class CheckoutForm : Form
    {
        private readonly List<string> basketItems;
        private readonly decimal totalPrice;
        private readonly CheckoutService checkoutService;

        public CheckoutForm(List<string> items, decimal total)
        {
            InitializeComponent();
            basketItems = items;
            totalPrice = total;
            checkoutService = new CheckoutService();

            LoadBasket();
        }

        private void LoadBasket()
        {
            lstItems.Items.Clear();

            foreach (string item in basketItems)
            {
                lstItems.Items.Add(item);
            }

            lblTotal.Text = "£" + totalPrice.ToString("F2");
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order
            {
                CustomerName = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                CardNumber = txtCardNumber.Text.Trim(),
                ExpiryDate = txtExpiry.Text.Trim(),
                CVV = txtCVV.Text.Trim(),
                Items = basketItems,
                TotalPrice = totalPrice,
                OrderDate = DateTime.Now
            };

            string errorMessage;
            if (!checkoutService.ValidateOrder(order, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            checkoutService.SaveOrder(order);

            MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}