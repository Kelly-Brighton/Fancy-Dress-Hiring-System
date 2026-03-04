namespace FancyDressHiringSystem
{
    partial class Home
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
            panel1 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            Sortby = new ComboBox();
            panel4 = new Panel();
            label17 = new Label();
            label13 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            label18 = new Label();
            label14 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(893, 61);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 37);
            label1.TabIndex = 0;
            label1.Text = "Attire Hire\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(723, 127);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 34);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(Sortby);
            panel3.Location = new Point(1161, 127);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(188, 38);
            panel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(4, 5);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 9;
            label4.Text = "Sort by ▼▲";
            label4.Click += label4_Click;
            // 
            // Sortby
            // 
            Sortby.Dock = DockStyle.Fill;
            Sortby.DropDownStyle = ComboBoxStyle.DropDownList;
            Sortby.FlatStyle = FlatStyle.Flat;
            Sortby.FormattingEnabled = true;
            Sortby.Items.AddRange(new object[] { "Price", "Name", "Rating" });
            Sortby.Location = new Point(0, 0);
            Sortby.Margin = new Padding(4);
            Sortby.Name = "Sortby";
            Sortby.Size = new Size(188, 27);
            Sortby.TabIndex = 0;
            Sortby.SelectedIndexChanged += comboBox1_SelectedIndexChanged_2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Highlight;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(723, 195);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(237, 312);
            panel4.TabIndex = 4;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(182, 270);
            label17.Name = "label17";
            label17.Size = new Size(30, 20);
            label17.TabIndex = 12;
            label17.Text = "🔗";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(96, 270);
            label13.Name = "label13";
            label13.Size = new Size(30, 20);
            label13.TabIndex = 11;
            label13.Text = "💬";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 270);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 10;
            label5.Text = "❤️";
            label5.Click += label5_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(pictureBox2);
            panel5.Location = new Point(1094, 195);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(237, 312);
            panel5.TabIndex = 5;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(183, 270);
            label18.Name = "label18";
            label18.Size = new Size(30, 20);
            label18.TabIndex = 13;
            label18.Text = "🔗";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(99, 270);
            label14.Name = "label14";
            label14.Size = new Size(30, 20);
            label14.TabIndex = 12;
            label14.Text = "💬";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 270);
            label6.Name = "label6";
            label6.Size = new Size(30, 20);
            label6.TabIndex = 11;
            label6.Text = "❤️";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(20, -1);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 188);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Home";
            Size = new Size(129, 116);
            Load += Home_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private Panel panel3;
        private ComboBox Sortby;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label13;
        private Label label5;
        private Label label14;
        private Label label6;
        private Label label17;
        private Label label18;
    }
}
