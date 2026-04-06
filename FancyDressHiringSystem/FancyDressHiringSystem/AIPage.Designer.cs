namespace FancyDressHiringSystem
{
    partial class AIPage
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
            flowAIResults = new FlowLayoutPanel();
            btnAskAI = new Button();
            txtAI = new TextBox();
            richAIResponse = new RichTextBox();
            SuspendLayout();
            // 
            // flowAIResults
            // 
            flowAIResults.AutoScroll = true;
            flowAIResults.Dock = DockStyle.Bottom;
            flowAIResults.Location = new Point(0, 212);
            flowAIResults.Name = "flowAIResults";
            flowAIResults.Size = new Size(777, 434);
            flowAIResults.TabIndex = 0;
            // 
            // btnAskAI
            // 
            btnAskAI.BackColor = Color.RosyBrown;
            btnAskAI.Location = new Point(247, 53);
            btnAskAI.Name = "btnAskAI";
            btnAskAI.Size = new Size(263, 35);
            btnAskAI.TabIndex = 1;
            btnAskAI.Text = "Ask AI";
            btnAskAI.UseVisualStyleBackColor = false;
            btnAskAI.Click += btnAskAI_Click;
            // 
            // txtAI
            // 
            txtAI.BackColor = SystemColors.Info;
            txtAI.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAI.Location = new Point(3, 3);
            txtAI.Multiline = true;
            txtAI.Name = "txtAI";
            txtAI.Size = new Size(771, 44);
            txtAI.TabIndex = 2;
            txtAI.Text = "Enter Enquiry";
            txtAI.TextChanged += txtAI_TextChanged;
            txtAI.Enter += txtAI_Enter;
            txtAI.Leave += txtAI_Leave;
            // 
            // richAIResponse
            // 
            richAIResponse.BackColor = SystemColors.Info;
            richAIResponse.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richAIResponse.Location = new Point(1, 97);
            richAIResponse.Name = "richAIResponse";
            richAIResponse.Size = new Size(773, 96);
            richAIResponse.TabIndex = 3;
            richAIResponse.Text = "";
            // 
            // AIPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(richAIResponse);
            Controls.Add(txtAI);
            Controls.Add(btnAskAI);
            Controls.Add(flowAIResults);
            Name = "AIPage";
            Size = new Size(777, 646);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowAIResults;
        private Button btnAskAI;
        private TextBox txtAI;
        private RichTextBox richAIResponse;
    }
}
