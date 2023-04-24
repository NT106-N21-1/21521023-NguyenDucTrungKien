namespace Lab3
{
    partial class Bai3_Client
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
            rtb_text = new RichTextBox();
            btnConnect = new Button();
            btnSend = new Button();
            btnDisconnect = new Button();
            SuspendLayout();
            // 
            // rtb_text
            // 
            rtb_text.Location = new Point(12, 12);
            rtb_text.Name = "rtb_text";
            rtb_text.Size = new Size(372, 114);
            rtb_text.TabIndex = 0;
            rtb_text.Text = "";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(412, 12);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(122, 34);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(412, 52);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(122, 34);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Enabled = false;
            btnDisconnect.Location = new Point(412, 92);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(122, 34);
            btnDisconnect.TabIndex = 3;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // Bai3_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 149);
            Controls.Add(btnDisconnect);
            Controls.Add(btnSend);
            Controls.Add(btnConnect);
            Controls.Add(rtb_text);
            Name = "Bai3_Client";
            Text = "TCP Client";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_text;
        private Button btnConnect;
        private Button btnSend;
        private Button btnDisconnect;
    }
}