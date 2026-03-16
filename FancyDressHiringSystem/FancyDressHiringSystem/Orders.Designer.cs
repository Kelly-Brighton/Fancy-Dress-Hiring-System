namespace FancyDressHiringSystem
{
    partial class Orders
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
            flowOrders = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowOrders
            // 
            flowOrders.AutoScroll = true;
            flowOrders.Dock = DockStyle.Fill;
            flowOrders.FlowDirection = FlowDirection.TopDown;
            flowOrders.Location = new Point(0, 0);
            flowOrders.Name = "flowOrders";
            flowOrders.Size = new Size(777, 646);
            flowOrders.TabIndex = 0;
            flowOrders.WrapContents = false;
            flowOrders.Paint += flowOrders_Paint;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(flowOrders);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Orders";
            Size = new Size(777, 646);
            Load += Orders_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowOrders;
    }
}
