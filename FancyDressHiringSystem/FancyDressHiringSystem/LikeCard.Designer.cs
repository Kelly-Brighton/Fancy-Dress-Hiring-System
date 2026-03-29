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
            this.btnLike = new Button();
            this.btnLike.Click += btnLike_Click;
            label1 = new Label();
            this.picImage = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.picImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnViewDetails);
            panel1.Controls.Add(this.btnLike);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(this.picImage);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 270);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.White;
            btnViewDetails.Dock = DockStyle.Bottom;
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Location = new Point(0, 235);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(230, 35);
            btnViewDetails.TabIndex = 3;
            btnViewDetails.Text = "view details";
            btnViewDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // btnLike
            // 
            this.btnLike.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnLike.FlatStyle = FlatStyle.Flat;
            this.btnLike.Location = new Point(193, 0);
            this.btnLike.Margin = new Padding(5);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new Size(37, 28);
            this.btnLike.TabIndex = 2;
            this.btnLike.Text = "♥";
            this.btnLike.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 130);
            label1.Name = "label1";
            label1.Size = new Size(230, 27);
            label1.TabIndex = 1;
            label1.Text = "Outfit";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picImage
            // 
            this.picImage.BackColor = Color.LightGray;
            this.picImage.BorderStyle = BorderStyle.FixedSingle;
            this.picImage.Dock = DockStyle.Top;
            this.picImage.Location = new Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new Size(230, 130);
            this.picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // LikeCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "LikeCard";
            Size = new Size(230, 270);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.picImage).EndInit();
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
