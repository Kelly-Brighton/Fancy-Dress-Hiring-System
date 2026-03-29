namespace FancyDressHiringSystem
{
    partial class Mainform
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
            btnLiked = new Button();
            lblBasket = new Label();
            panel2 = new Panel();
            btnLog = new Button();
            btnBask = new Button();
            btnOrders = new Button();
            btnHome = new Button();
            panelContainer = new Panel();
            lblLiked = new Label();
            lblOrders = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(lblOrders);
            panel1.Controls.Add(lblLiked);
            panel1.Controls.Add(btnLiked);
            panel1.Controls.Add(lblBasket);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnLog);
            panel1.Controls.Add(btnBask);
            panel1.Controls.Add(btnOrders);
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 646);
            panel1.TabIndex = 0;
            // 
            // btnLiked
            // 
            btnLiked.BackColor = SystemColors.Info;
            btnLiked.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLiked.Location = new Point(0, 168);
            btnLiked.Name = "btnLiked";
            btnLiked.Size = new Size(200, 49);
            btnLiked.TabIndex = 5;
            btnLiked.Text = "Liked";
            btnLiked.UseVisualStyleBackColor = false;
            btnLiked.Click += btnLiked_Click;
            // 
            // lblBasket
            // 
            lblBasket.AutoSize = true;
            lblBasket.BackColor = SystemColors.Info;
            lblBasket.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBasket.Location = new Point(128, 122);
            lblBasket.Name = "lblBasket";
            lblBasket.Size = new Size(18, 14);
            lblBasket.TabIndex = 4;
            lblBasket.Text = "lbl";
            // 
            // panel2
            // 
            panel2.Location = new Point(206, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(607, 422);
            panel2.TabIndex = 1;
            // 
            // btnLog
            // 
            btnLog.BackColor = SystemColors.Info;
            btnLog.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLog.Location = new Point(0, 594);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(200, 49);
            btnLog.TabIndex = 3;
            btnLog.Text = "Log out";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // btnBask
            // 
            btnBask.BackColor = SystemColors.Info;
            btnBask.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBask.Location = new Point(0, 113);
            btnBask.Name = "btnBask";
            btnBask.Size = new Size(200, 49);
            btnBask.TabIndex = 2;
            btnBask.Text = "Basket";
            btnBask.UseVisualStyleBackColor = false;
            btnBask.Click += btnLikes_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = SystemColors.Info;
            btnOrders.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.Location = new Point(0, 58);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(200, 49);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.Info;
            btnHome.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(0, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(200, 49);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(207, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(777, 646);
            panelContainer.TabIndex = 1;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // lblLiked
            // 
            lblLiked.AutoSize = true;
            lblLiked.BackColor = SystemColors.Info;
            lblLiked.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLiked.Location = new Point(128, 178);
            lblLiked.Name = "lblLiked";
            lblLiked.Size = new Size(18, 14);
            lblLiked.TabIndex = 6;
            lblLiked.Text = "lbl";
            // 
            // lblOrders
            // 
            lblOrders.AutoSize = true;
            lblOrders.BackColor = SystemColors.Info;
            lblOrders.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrders.Location = new Point(128, 68);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(18, 14);
            lblOrders.TabIndex = 7;
            lblOrders.Text = "lbl";
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(987, 648);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Mainform";
            Text = "Mainform";
            Load += Mainform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnHome;
        private Button btnLog;
        private Button btnBask;
        private Button btnOrders;
        private Panel panel2;
        private Panel panelContainer;
        private Label lblBasket;
        private Button btnLiked;
        private Label lblLiked;
        private Label lblOrders;
    }
}