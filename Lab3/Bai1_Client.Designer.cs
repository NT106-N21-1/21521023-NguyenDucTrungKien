namespace Lab3
{
    partial class Bai1_Client
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
            btnSend = new Button();
            rtbMess = new RichTextBox();
            txt_Port = new TextBox();
            txt_IP = new TextBox();
            lblMess = new Label();
            lblPort = new Label();
            lbl_IP = new Label();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(12, 409);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 13;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // rtbMess
            // 
            rtbMess.Location = new Point(12, 273);
            rtbMess.Name = "rtbMess";
            rtbMess.Size = new Size(648, 120);
            rtbMess.TabIndex = 12;
            rtbMess.Text = "";
            // 
            // txt_Port
            // 
            txt_Port.Location = new Point(535, 31);
            txt_Port.Name = "txt_Port";
            txt_Port.Size = new Size(125, 27);
            txt_Port.TabIndex = 11;
            // 
            // txt_IP
            // 
            txt_IP.Location = new Point(12, 31);
            txt_IP.Name = "txt_IP";
            txt_IP.Size = new Size(257, 27);
            txt_IP.TabIndex = 10;
            // 
            // lblMess
            // 
            lblMess.AutoSize = true;
            lblMess.Location = new Point(12, 250);
            lblMess.Name = "lblMess";
            lblMess.Size = new Size(67, 20);
            lblMess.TabIndex = 9;
            lblMess.Text = "Message";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(535, 8);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(35, 20);
            lblPort.TabIndex = 8;
            lblPort.Text = "Port";
            // 
            // lbl_IP
            // 
            lbl_IP.AutoSize = true;
            lbl_IP.Location = new Point(12, 8);
            lbl_IP.Name = "lbl_IP";
            lbl_IP.Size = new Size(109, 20);
            lbl_IP.TabIndex = 7;
            lbl_IP.Text = "IP Remote host";
            // 
            // Bai1_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 450);
            Controls.Add(btnSend);
            Controls.Add(rtbMess);
            Controls.Add(txt_Port);
            Controls.Add(txt_IP);
            Controls.Add(lblMess);
            Controls.Add(lblPort);
            Controls.Add(lbl_IP);
            Name = "Bai1_Client";
            Text = "UDP Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private RichTextBox rtbMess;
        private TextBox txt_Port;
        private TextBox txt_IP;
        private Label lblMess;
        private Label lblPort;
        private Label lbl_IP;
    }
}