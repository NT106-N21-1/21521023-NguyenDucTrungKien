namespace Lab3
{
    partial class Bai1_Server
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
            lblPort = new Label();
            lblReceiveMess = new Label();
            txtPort = new TextBox();
            richTextBox1 = new RichTextBox();
            btnLis = new Button();
            SuspendLayout();
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(12, 50);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(35, 20);
            lblPort.TabIndex = 0;
            lblPort.Text = "Port";
            // 
            // lblReceiveMess
            // 
            lblReceiveMess.AutoSize = true;
            lblReceiveMess.Location = new Point(12, 172);
            lblReceiveMess.Name = "lblReceiveMess";
            lblReceiveMess.Size = new Size(128, 20);
            lblReceiveMess.TabIndex = 1;
            lblReceiveMess.Text = "Receive messages";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(53, 47);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(125, 27);
            txtPort.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 195);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(639, 243);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // btnLis
            // 
            btnLis.Location = new Point(557, 46);
            btnLis.Name = "btnLis";
            btnLis.Size = new Size(94, 29);
            btnLis.TabIndex = 4;
            btnLis.Text = "Listen";
            btnLis.UseVisualStyleBackColor = true;
            btnLis.Click += btnLis_Click;
            // 
            // Bai1_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 450);
            Controls.Add(btnLis);
            Controls.Add(richTextBox1);
            Controls.Add(txtPort);
            Controls.Add(lblReceiveMess);
            Controls.Add(lblPort);
            Name = "Bai1_Server";
            Text = "UDP Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPort;
        private Label lblReceiveMess;
        private TextBox txtPort;
        private RichTextBox richTextBox1;
        private Button btnLis;
    }
}