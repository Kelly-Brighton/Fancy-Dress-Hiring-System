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
            label5 = new Label();
            lblCostumeName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(4, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(23, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 147);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 2;
            label1.Text = "SIZE :";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(281, 52);
            lblSize.Margin = new Padding(2, 0, 2, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(42, 17);
            lblSize.TabIndex = 3;
            lblSize.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(487, 8);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 19);
            label2.TabIndex = 4;
            label2.Text = "ORDER DATE :";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderDate.Location = new Point(613, 10);
            lblOrderDate.Margin = new Padding(2, 0, 2, 0);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(42, 17);
            lblOrderDate.TabIndex = 5;
            lblOrderDate.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(487, 50);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 19);
            label3.TabIndex = 6;
            label3.Text = "RETURN DATE:";
            label3.Click += label3_Click;
            // 
            // lblOrderDueDate
            // 
            lblOrderDueDate.AutoSize = true;
            lblOrderDueDate.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderDueDate.Location = new Point(618, 52);
            lblOrderDueDate.Margin = new Padding(2, 0, 2, 0);
            lblOrderDueDate.Name = "lblOrderDueDate";
            lblOrderDueDate.Size = new Size(42, 17);
            lblOrderDueDate.TabIndex = 7;
            lblOrderDueDate.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(227, 96);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 8;
            label4.Text = "STATUS :";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(307, 98);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 17);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "label5";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Crimson;
            btnCancel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(487, 115);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 30);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(226, 8);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 11;
            label5.Text = "NAME:";
            // 
            // lblCostumeName
            // 
            lblCostumeName.AutoSize = true;
            lblCostumeName.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCostumeName.Location = new Point(288, 10);
            lblCostumeName.Name = "lblCostumeName";
            lblCostumeName.Size = new Size(42, 17);
            lblCostumeName.TabIndex = 12;
            lblCostumeName.Text = "label6";
            // 
            // OrderCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblCostumeName);
            Controls.Add(label5);
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
            Margin = new Padding(2);
            Name = "OrderCard";
            Size = new Size(741, 154);
            Load += OrderCard_Load;
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
        private Label label5;
        private Label lblCostumeName;
    }
}
