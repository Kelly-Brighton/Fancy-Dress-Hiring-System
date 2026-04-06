namespace FancyDressHiringSystem
{
    partial class UC_Orders
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
            dataOrders = new DataGridView();
            panel1 = new Panel();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataOrders).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataOrders
            // 
            dataOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataOrders.BackgroundColor = SystemColors.GradientActiveCaption;
            dataOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataOrders.Location = new Point(0, 53);
            dataOrders.Name = "dataOrders";
            dataOrders.Size = new Size(777, 593);
            dataOrders.TabIndex = 0;
            dataOrders.CellContentClick += dataOrders_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUpdate);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 50);
            panel1.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.Location = new Point(0, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 44);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update Status";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UC_Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(panel1);
            Controls.Add(dataOrders);
            Name = "UC_Orders";
            Size = new Size(777, 646);
            ((System.ComponentModel.ISupportInitialize)dataOrders).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataOrders;
        private Panel panel1;
        private Button btnUpdate;
    }
}
