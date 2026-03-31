namespace FancyDressHiringSystem
{
    partial class CheckoutForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmailText;
        private System.Windows.Forms.Label lblAddressText;
        private System.Windows.Forms.Label lblCardNumberText;
        private System.Windows.Forms.Label lblExpiryText;
        private System.Windows.Forms.Label lblCVVText;
        private System.Windows.Forms.Label lblBasketText;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmailText = new System.Windows.Forms.Label();
            this.lblAddressText = new System.Windows.Forms.Label();
            this.lblCardNumberText = new System.Windows.Forms.Label();
            this.lblExpiryText = new System.Windows.Forms.Label();
            this.lblCVVText = new System.Windows.Forms.Label();
            this.lblBasketText = new System.Windows.Forms.Label();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtExpiry = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Text = "Checkout";

            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 70);
            this.lblName.Text = "Name";
            this.txtName.Location = new System.Drawing.Point(25, 90);
            this.txtName.Size = new System.Drawing.Size(240, 23);

            this.lblEmailText.AutoSize = true;
            this.lblEmailText.Location = new System.Drawing.Point(25, 125);
            this.lblEmailText.Text = "Email";
            this.txtEmail.Location = new System.Drawing.Point(25, 145);
            this.txtEmail.Size = new System.Drawing.Size(240, 23);

            this.lblAddressText.AutoSize = true;
            this.lblAddressText.Location = new System.Drawing.Point(25, 180);
            this.lblAddressText.Text = "Address";
            this.txtAddress.Location = new System.Drawing.Point(25, 200);
            this.txtAddress.Multiline = true;
            this.txtAddress.Size = new System.Drawing.Size(240, 60);

            this.lblCardNumberText.AutoSize = true;
            this.lblCardNumberText.Location = new System.Drawing.Point(25, 275);
            this.lblCardNumberText.Text = "Card Number";
            this.txtCardNumber.Location = new System.Drawing.Point(25, 295);
            this.txtCardNumber.Size = new System.Drawing.Size(240, 23);

            this.lblExpiryText.AutoSize = true;
            this.lblExpiryText.Location = new System.Drawing.Point(25, 330);
            this.lblExpiryText.Text = "Expiry Date";
            this.txtExpiry.Location = new System.Drawing.Point(25, 350);
            this.txtExpiry.Size = new System.Drawing.Size(110, 23);

            this.lblCVVText.AutoSize = true;
            this.lblCVVText.Location = new System.Drawing.Point(155, 330);
            this.lblCVVText.Text = "CVV";
            this.txtCVV.Location = new System.Drawing.Point(155, 350);
            this.txtCVV.Size = new System.Drawing.Size(110, 23);

            this.lblBasketText.AutoSize = true;
            this.lblBasketText.Location = new System.Drawing.Point(310, 70);
            this.lblBasketText.Text = "Basket Items";
            this.lstItems.Location = new System.Drawing.Point(310, 90);
            this.lstItems.Size = new System.Drawing.Size(240, 214);

            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Location = new System.Drawing.Point(310, 330);
            this.lblTotalText.Text = "Total:";
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(360, 330);
            this.lblTotal.Text = "£0.00";

            this.btnPlaceOrder.Location = new System.Drawing.Point(310, 380);
            this.btnPlaceOrder.Size = new System.Drawing.Size(110, 35);
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);

            this.btnCancel.Location = new System.Drawing.Point(440, 380);
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmailText);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAddressText);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblCardNumberText);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblExpiryText);
            this.Controls.Add(this.txtExpiry);
            this.Controls.Add(this.lblCVVText);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.lblBasketText);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.lblTotalText);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnCancel);
            this.Name = "CheckoutForm";
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}