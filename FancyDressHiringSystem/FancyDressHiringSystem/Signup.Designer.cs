namespace FancyDressHiringSystem
{
    partial class btnSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnSignUp));
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            panel4 = new Panel();
            txtConfirm = new TextBox();
            txtPassword = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(470, 375);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(124, 38);
            button1.TabIndex = 0;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(361, 104);
            label2.Name = "label2";
            label2.Size = new Size(135, 19);
            label2.TabIndex = 7;
            label2.Text = "Username or email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 74);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(367, 197);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(367, 279);
            label5.Name = "label5";
            label5.Size = new Size(129, 19);
            label5.TabIndex = 10;
            label5.Text = "Confirm password";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 440);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SteelBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 422);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.SteelBlue;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Location = new Point(367, 126);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(330, 39);
            txtUser.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(367, 163);
            panel4.Name = "panel4";
            panel4.Size = new Size(330, 2);
            panel4.TabIndex = 16;
            // 
            // txtConfirm
            // 
            txtConfirm.BackColor = Color.SteelBlue;
            txtConfirm.BorderStyle = BorderStyle.None;
            txtConfirm.Location = new Point(367, 301);
            txtConfirm.Multiline = true;
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(330, 39);
            txtConfirm.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.SteelBlue;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(367, 219);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(330, 39);
            txtPassword.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(367, 256);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 2);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(367, 338);
            panel3.Name = "panel3";
            panel3.Size = new Size(330, 2);
            panel3.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(406, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 58);
            label1.TabIndex = 21;
            label1.Text = "Fancy Dress";
            // 
            // btnSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(723, 440);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(txtPassword);
            Controls.Add(txtConfirm);
            Controls.Add(panel4);
            Controls.Add(txtUser);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "btnSignUp";
            Text = "Signup";
            Load += Signup_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtUser;
        private Panel panel4;
        private TextBox txtConfirm;
        private TextBox txtPassword;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
    }
}