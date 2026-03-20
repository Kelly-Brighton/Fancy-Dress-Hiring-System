namespace FancyDressHiringSystem
{
    partial class Admin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnLogout = new Button();
            btnUpload = new Button();
            btnOrders = new Button();
            btnInventory = new Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnUpload);
            panel1.Controls.Add(btnOrders);
            panel1.Controls.Add(btnInventory);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 646);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.Info;
            btnLogout.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(0, 603);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 43);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = SystemColors.Info;
            btnUpload.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(0, 101);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(200, 43);
            btnUpload.TabIndex = 2;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = SystemColors.Info;
            btnOrders.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.Location = new Point(0, 52);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(200, 43);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = SystemColors.Info;
            btnInventory.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.Location = new Point(0, 3);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(200, 43);
            btnInventory.TabIndex = 0;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(208, 3);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(777, 646);
            panelContainer.TabIndex = 1;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(987, 652);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Button btnUpload;
        private Button btnOrders;
        private Button btnInventory;
        private Panel panelContainer;
    }
}