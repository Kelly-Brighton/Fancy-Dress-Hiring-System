namespace FancyDressHiringSystem
{
    partial class LikeCard
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
            panel1 = new Panel();
            btnViewDetails = new Button();
            btnLike = new Button();
            label1 = new Label();
            picImage = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnViewDetails);
            panel1.Controls.Add(btnLike);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(picImage);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 202);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.White;
            btnViewDetails.Dock = DockStyle.Bottom;
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Location = new Point(0, 176);
            btnViewDetails.Margin = new Padding(3, 2, 3, 2);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(201, 26);
            btnViewDetails.TabIndex = 3;
            btnViewDetails.Text = "view details";
            btnViewDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // btnLike
            // 
            btnLike.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLike.FlatStyle = FlatStyle.Flat;
            btnLike.Location = new Point(169, 0);
            btnLike.Margin = new Padding(4, 4, 4, 4);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(32, 21);
            btnLike.TabIndex = 2;
            btnLike.Text = "♥";
            btnLike.UseVisualStyleBackColor = true;
            btnLike.Click += btnLike_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 98);
            label1.Name = "label1";
            label1.Size = new Size(201, 20);
            label1.TabIndex = 1;
            label1.Text = "Outfit";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picImage
            // 
            picImage.BackColor = Color.LightGray;
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Dock = DockStyle.Top;
            picImage.Location = new Point(0, 0);
            picImage.Margin = new Padding(3, 2, 3, 2);
            picImage.Name = "picImage";
            picImage.Size = new Size(201, 98);
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picImage.TabIndex = 0;
            picImage.TabStop = false;
            picImage.Click += picImage_Click;
            // 
            // LikeCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LikeCard";
            Size = new Size(201, 202);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLike;
        private PictureBox picImage;
        private Label label1;
        private Button btnViewDetails;
        private Panel panel1;
    }
}
