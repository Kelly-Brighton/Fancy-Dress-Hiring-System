namespace FancyDressHiringSystem
{
    partial class CheckOut
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
            dataGridView1 = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            txtCard = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtExpiry = new TextBox();
            txtCVV = new TextBox();
            txtName = new TextBox();
            btnOrder = new Button();
            lblShipping = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colName, colQty, colPrice });
            dataGridView1.Location = new Point(458, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(342, 307);
            dataGridView1.TabIndex = 0;
            // 
            // colName
            // 
            colName.HeaderText = "Costume";
            colName.Name = "colName";
            // 
            // colQty
            // 
            colQty.HeaderText = "Quantity";
            colQty.Name = "colQty";
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price (£)";
            colPrice.Name = "colPrice";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lblTotal.Location = new Point(512, 338);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 22);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            label1.Location = new Point(458, 338);
            label1.Name = "label1";
            label1.Size = new Size(73, 22);
            label1.TabIndex = 4;
            label1.Text = "Price: £";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 21);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 6;
            label2.Text = "Card Number*";
            // 
            // txtCard
            // 
            txtCard.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCard.Location = new Point(17, 43);
            txtCard.Multiline = true;
            txtCard.Name = "txtCard";
            txtCard.Size = new Size(392, 37);
            txtCard.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 119);
            label3.Name = "label3";
            label3.Size = new Size(156, 19);
            label3.TabIndex = 8;
            label3.Text = "Expiration (MM/YY)*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 224);
            label4.Name = "label4";
            label4.Size = new Size(114, 19);
            label4.TabIndex = 10;
            label4.Text = "Name on Card*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(246, 122);
            label5.Name = "label5";
            label5.Size = new Size(158, 19);
            label5.TabIndex = 12;
            label5.Text = "Security Code (CVV)*";
            // 
            // txtExpiry
            // 
            txtExpiry.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExpiry.Location = new Point(17, 144);
            txtExpiry.Multiline = true;
            txtExpiry.Name = "txtExpiry";
            txtExpiry.Size = new Size(182, 37);
            txtExpiry.TabIndex = 13;
            // 
            // txtCVV
            // 
            txtCVV.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCVV.Location = new Point(246, 144);
            txtCVV.Multiline = true;
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(163, 37);
            txtCVV.TabIndex = 14;
            // 
            // txtName
            // 
            txtName.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(17, 246);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(392, 37);
            txtName.TabIndex = 15;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = SystemColors.Info;
            btnOrder.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.Location = new Point(50, 302);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(334, 39);
            btnOrder.TabIndex = 16;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // lblShipping
            // 
            lblShipping.AutoSize = true;
            lblShipping.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShipping.Location = new Point(458, 310);
            lblShipping.Name = "lblShipping";
            lblShipping.Size = new Size(0, 22);
            lblShipping.TabIndex = 17;
            // 
            // CheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(819, 359);
            Controls.Add(lblShipping);
            Controls.Add(btnOrder);
            Controls.Add(txtName);
            Controls.Add(txtCVV);
            Controls.Add(txtExpiry);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCard);
            Controls.Add(label2);
            Controls.Add(lblTotal);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "CheckOut";
            Text = "CheckOutForm";
            Load += CheckOutForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblTotal;
        private Label label1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colPrice;
        private Label label2;
        private TextBox txtCard;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtExpiry;
        private TextBox txtCVV;
        private TextBox txtName;
        private Button btnOrder;
        private Label lblShipping;
    }
}