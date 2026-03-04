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
            panel2 = new Panel();
            btnLog = new Button();
            btnLikes = new Button();
            btnOrders = new Button();
            btnHome = new Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnLog);
            panel1.Controls.Add(btnLikes);
            panel1.Controls.Add(btnOrders);
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 739);
            panel1.TabIndex = 0;
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
            btnLog.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLog.Location = new Point(0, 688);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(200, 49);
            btnLog.TabIndex = 3;
            btnLog.Text = "Log out";
            btnLog.UseVisualStyleBackColor = true;
            // 
            // btnLikes
            // 
            btnLikes.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLikes.Location = new Point(0, 113);
            btnLikes.Name = "btnLikes";
            btnLikes.Size = new Size(200, 49);
            btnLikes.TabIndex = 2;
            btnLikes.Text = "Likes";
            btnLikes.UseVisualStyleBackColor = true;
            btnLikes.Click += btnLikes_Click;
            // 
            // btnOrders
            // 
            btnOrders.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOrders.Location = new Point(0, 58);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(200, 49);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(0, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(200, 49);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(207, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(777, 739);
            panelContainer.TabIndex = 1;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 741);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Mainform";
            Text = "Mainform";
            Load += Mainform_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnHome;
        private Button btnLog;
        private Button btnLikes;
        private Button btnOrders;
        private Panel panel2;
        private Panel panelContainer;
    }
}