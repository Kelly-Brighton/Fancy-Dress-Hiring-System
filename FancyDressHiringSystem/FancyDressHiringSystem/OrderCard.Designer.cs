namespace FancyDressHiringSystem
{
    partial class OrderCard
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            lblSize = new Label();
            label2 = new Label();
            lblOrderDate = new Label();
            label3 = new Label();
            lblOrderDueDate = new Label();
            label4 = new Label();
            lblStatus = new Label();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(35, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 205);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(25, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 251);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 68);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 2;
            label1.Text = "SIZE :";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(413, 70);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(71, 30);
            lblSize.TabIndex = 3;
            lblSize.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(330, 118);
            label2.Name = "label2";
            label2.Size = new Size(176, 32);
            label2.TabIndex = 4;
            label2.Text = "ORDER DATE :";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOrderDate.Location = new Point(512, 120);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(71, 30);
            lblOrderDate.TabIndex = 5;
            lblOrderDate.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(330, 172);
            label3.Name = "label3";
            label3.Size = new Size(224, 32);
            label3.TabIndex = 6;
            label3.Text = "ORDER DUE DATE:";
            // 
            // lblOrderDueDate
            // 
            lblOrderDueDate.AutoSize = true;
            lblOrderDueDate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOrderDueDate.Location = new Point(560, 174);
            lblOrderDueDate.Name = "lblOrderDueDate";
            lblOrderDueDate.Size = new Size(72, 30);
            lblOrderDueDate.TabIndex = 7;
            lblOrderDueDate.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(330, 230);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 8;
            label4.Text = "STATUS :";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(452, 232);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(71, 30);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "label5";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Crimson;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(617, 257);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(139, 50);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // OrderCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(btnCancel);
            Controls.Add(lblStatus);
            Controls.Add(label4);
            Controls.Add(lblOrderDueDate);
            Controls.Add(label3);
            Controls.Add(lblOrderDate);
            Controls.Add(label2);
            Controls.Add(lblSize);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "OrderCard";
            Size = new Size(777, 323);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label lblSize;
        private Label label2;
        private Label lblOrderDate;
        private Label label3;
        private Label lblOrderDueDate;
        private Label label4;
        private Label lblStatus;
        private Button btnCancel;
    }
}
