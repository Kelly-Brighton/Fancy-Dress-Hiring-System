namespace FancyDressHiringSystem
{
    partial class BasketCard
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericCount = new NumericUpDown();
            btnDelete = new Button();
            lblShipping = new Label();
            lblName = new Label();
            lblGender = new Label();
            lblSize = new Label();
            lblPrice = new Label();
            chkSelect = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCount).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
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
            panel1.Location = new Point(25, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 147);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 6);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(414, 4);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 3;
            label2.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(245, 46);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 4;
            label3.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(245, 87);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 5;
            label4.Text = "Size:";
            // 
            // numericCount
            // 
            numericCount.BackColor = SystemColors.Info;
            numericCount.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericCount.Location = new Point(245, 127);
            numericCount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericCount.Name = "numericCount";
            numericCount.Size = new Size(120, 25);
            numericCount.TabIndex = 2;
            numericCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(457, 116);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 36);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblShipping
            // 
            lblShipping.AutoSize = true;
            lblShipping.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShipping.Location = new Point(414, 46);
            lblShipping.Name = "lblShipping";
            lblShipping.Size = new Size(47, 17);
            lblShipping.TabIndex = 9;
            lblShipping.Text = "label5";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(293, 8);
            lblName.Name = "lblName";
            lblName.Size = new Size(40, 15);
            lblName.TabIndex = 10;
            lblName.Text = "label5";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(304, 48);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(40, 15);
            lblGender.TabIndex = 11;
            lblGender.Text = "label5";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(281, 89);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(40, 15);
            lblSize.TabIndex = 12;
            lblSize.Text = "label5";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(457, 6);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(40, 15);
            lblPrice.TabIndex = 13;
            lblPrice.Text = "label5";
            // 
            // chkSelect
            // 
            chkSelect.AutoSize = true;
            chkSelect.Location = new Point(554, 1);
            chkSelect.Name = "chkSelect";
            chkSelect.Size = new Size(15, 14);
            chkSelect.TabIndex = 14;
            chkSelect.UseVisualStyleBackColor = true;
            chkSelect.CheckedChanged += chkSelect_CheckedChanged;
            // 
            // BasketCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(chkSelect);
            Controls.Add(lblPrice);
            Controls.Add(lblSize);
            Controls.Add(lblGender);
            Controls.Add(lblName);
            Controls.Add(lblShipping);
            Controls.Add(btnDelete);
            Controls.Add(numericCount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "BasketCard";
            Size = new Size(572, 154);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericCount;
        private Button btnDelete;
        private Label lblShipping;
        private Label lblName;
        private Label lblGender;
        private Label lblSize;
        private Label lblPrice;
        private CheckBox chkSelect;
    }
}
