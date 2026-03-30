namespace FancyDressHiringSystem
{
    partial class Likes
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
            flowLikes = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLikes
            // 
            flowLikes.AutoScroll = true;
            flowLikes.Dock = DockStyle.Fill;
            flowLikes.Location = new Point(0, 0);
            flowLikes.Name = "flowLikes";
            flowLikes.Size = new Size(777, 646);
            flowLikes.TabIndex = 25;
            flowLikes.Paint += flowLayoutPanel1_Paint;
            // 
            // Likes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(flowLikes);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Likes";
            Size = new Size(777, 646);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLikes;
    }
}
