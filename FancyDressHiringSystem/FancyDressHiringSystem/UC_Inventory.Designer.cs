namespace FancyDressHiringSystem
{
    partial class UC_Inventory
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
            flowInventory = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowInventory
            // 
            flowInventory.AutoScroll = true;
            flowInventory.Dock = DockStyle.Fill;
            flowInventory.Location = new Point(0, 0);
            flowInventory.Name = "flowInventory";
            flowInventory.Size = new Size(777, 646);
            flowInventory.TabIndex = 0;
            flowInventory.Paint += flowLayout_Paint;
            // 
            // UC_Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowInventory);
            Name = "UC_Inventory";
            Size = new Size(777, 646);
            Load += UC_Inventory_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowInventory;
    }
}
