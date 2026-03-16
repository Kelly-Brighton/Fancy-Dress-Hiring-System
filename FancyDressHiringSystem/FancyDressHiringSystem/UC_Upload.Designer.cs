namespace FancyDressHiringSystem
{
    partial class UC_Upload
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
            label1 = new Label();
            txtName = new TextBox();
            cmbGender = new ComboBox();
            cmbSize = new ComboBox();
            label5 = new Label();
            txtPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnUpload = new Button();
            btnSave = new Button();
            picPreview = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 235);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(290, 235);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 32);
            txtName.TabIndex = 4;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(290, 383);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(193, 23);
            cmbGender.TabIndex = 6;
            // 
            // cmbSize
            // 
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(290, 448);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(193, 23);
            cmbSize.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(205, 308);
            label5.Name = "label5";
            label5.Size = new Size(48, 19);
            label5.TabIndex = 8;
            label5.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(290, 308);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(193, 32);
            txtPrice.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 383);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 10;
            label2.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(205, 452);
            label3.Name = "label3";
            label3.Size = new Size(41, 19);
            label3.TabIndex = 11;
            label3.Text = "Size:";
            // 
            // btnUpload
            // 
            btnUpload.BackColor = SystemColors.Info;
            btnUpload.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(215, 546);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(115, 36);
            btnUpload.TabIndex = 12;
            btnUpload.Text = "Upload Image";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Info;
            btnSave.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(410, 546);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 36);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // picPreview
            // 
            picPreview.Location = new Point(93, 3);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(583, 218);
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picPreview.TabIndex = 15;
            picPreview.TabStop = false;
            // 
            // UC_Upload
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(picPreview);
            Controls.Add(btnSave);
            Controls.Add(btnUpload);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(cmbSize);
            Controls.Add(cmbGender);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "UC_Upload";
            Size = new Size(777, 646);
            Load += UC_Upload_Load;
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private ComboBox cmbGender;
        private ComboBox cmbSize;
        private Label label5;
        private TextBox txtPrice;
        private Label label2;
        private Label label3;
        private Button btnUpload;
        private Button btnSave;
        private PictureBox picPreview;
    }
}
