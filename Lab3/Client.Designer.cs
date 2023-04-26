namespace LAB03_BAI04
{
    partial class Client
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
            this.messageTB = new System.Windows.Forms.TextBox();
            this.ConnectBT = new System.Windows.Forms.Button();
            this.SendBT = new System.Windows.Forms.Button();
            this.DisconnectBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageTB
            // 
            this.messageTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageTB.Location = new System.Drawing.Point(12, 37);
            this.messageTB.Multiline = true;
            this.messageTB.Name = "messageTB";
            this.messageTB.Size = new System.Drawing.Size(459, 210);
            this.messageTB.TabIndex = 0;
            // 
            // ConnectBT
            // 
            this.ConnectBT.Location = new System.Drawing.Point(499, 37);
            this.ConnectBT.Name = "ConnectBT";
            this.ConnectBT.Size = new System.Drawing.Size(155, 44);
            this.ConnectBT.TabIndex = 1;
            this.ConnectBT.Text = "Connect";
            this.ConnectBT.UseVisualStyleBackColor = true;
            this.ConnectBT.Click += new System.EventHandler(this.ConnectBT_Click);
            // 
            // SendBT
            // 
            this.SendBT.Enabled = false;
            this.SendBT.Location = new System.Drawing.Point(499, 122);
            this.SendBT.Name = "SendBT";
            this.SendBT.Size = new System.Drawing.Size(155, 44);
            this.SendBT.TabIndex = 2;
            this.SendBT.Text = "Send";
            this.SendBT.UseVisualStyleBackColor = true;
            this.SendBT.Click += new System.EventHandler(this.SendBT_Click);
            // 
            // DisconnectBT
            // 
            this.DisconnectBT.Enabled = false;
            this.DisconnectBT.Location = new System.Drawing.Point(499, 203);
            this.DisconnectBT.Name = "DisconnectBT";
            this.DisconnectBT.Size = new System.Drawing.Size(155, 44);
            this.DisconnectBT.TabIndex = 3;
            this.DisconnectBT.Text = "Disconnect";
            this.DisconnectBT.UseVisualStyleBackColor = true;
            this.DisconnectBT.Click += new System.EventHandler(this.DisconnectBT_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 272);
            this.Controls.Add(this.DisconnectBT);
            this.Controls.Add(this.SendBT);
            this.Controls.Add(this.ConnectBT);
            this.Controls.Add(this.messageTB);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox messageTB;
        private Button ConnectBT;
        private Button SendBT;
        private Button DisconnectBT;
    }
}