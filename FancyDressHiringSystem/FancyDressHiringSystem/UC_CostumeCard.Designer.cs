namespace FancyDressHiringSystem
{
    partial class UC_CostumeCard
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
            lblCostumeName = new Label();
            lblPrice = new Label();
            label3 = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            lblClothName = new Label();
            lblClothPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblCostumeName
            // 
            lblCostumeName.AutoSize = true;
            lblCostumeName.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCostumeName.Location = new Point(3, 164);
            lblCostumeName.Name = "lblCostumeName";
            lblCostumeName.Size = new Size(42, 15);
            lblCostumeName.TabIndex = 1;
            lblCostumeName.Text = "Name:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(3, 199);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 230);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 3;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.Info;
            btnEdit.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(18, 219);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 37);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(127, 219);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 37);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblClothName
            // 
            lblClothName.AutoSize = true;
            lblClothName.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClothName.Location = new Point(51, 164);
            lblClothName.Name = "lblClothName";
            lblClothName.Size = new Size(40, 15);
            lblClothName.TabIndex = 6;
            lblClothName.Text = "label1";
            // 
            // lblClothPrice
            // 
            lblClothPrice.AutoSize = true;
            lblClothPrice.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClothPrice.Location = new Point(50, 199);
            lblClothPrice.Name = "lblClothPrice";
            lblClothPrice.Size = new Size(40, 15);
            lblClothPrice.TabIndex = 7;
            lblClothPrice.Text = "label2";
            // 
            // UC_CostumeCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblClothPrice);
            Controls.Add(lblClothName);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(label3);
            Controls.Add(lblPrice);
            Controls.Add(lblCostumeName);
            Controls.Add(pictureBox1);
            Name = "UC_CostumeCard";
            Size = new Size(218, 258);
            Load += UC_CostumeCard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCostumeName;
        private Label lblPrice;
        private Label label3;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblClothName;
        private Label lblClothPrice;
    }
}
