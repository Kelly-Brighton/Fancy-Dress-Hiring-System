namespace FancyDressHiringSystem
{
    partial class lblTotal
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowBasket = new FlowLayoutPanel();
            btnCheckout = new Button();
            SuspendLayout();
            // 
            // flowBasket
            // 
            flowBasket.AutoScroll = true;
            flowBasket.Dock = DockStyle.Left;
            flowBasket.FlowDirection = FlowDirection.TopDown;
            flowBasket.Location = new Point(0, 0);
            flowBasket.Name = "flowBasket";
            flowBasket.Size = new Size(594, 646);
            flowBasket.TabIndex = 0;
            flowBasket.Paint += flowBasket_Paint;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = SystemColors.Info;
            btnCheckout.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.Location = new Point(600, 3);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(174, 35);
            btnCheckout.TabIndex = 1;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // lblTotal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(btnCheckout);
            Controls.Add(flowBasket);
            Name = "lblTotal";
            Size = new Size(777, 646);
            Load += lblTotal_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowBasket;
        private Button btnCheckout;
    }
}
