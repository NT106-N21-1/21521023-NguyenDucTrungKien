namespace Lab3
{
    partial class Bai3
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
            btn_Server = new Button();
            btnClient = new Button();
            SuspendLayout();
            // 
            // btn_Server
            // 
            btn_Server.Location = new Point(89, 55);
            btn_Server.Name = "btn_Server";
            btn_Server.Size = new Size(435, 50);
            btn_Server.TabIndex = 0;
            btn_Server.Text = "Open TCP Server";
            btn_Server.UseVisualStyleBackColor = true;
            btn_Server.Click += btn_Server_Click;
            // 
            // btnClient
            // 
            btnClient.Location = new Point(89, 142);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(435, 50);
            btnClient.TabIndex = 1;
            btnClient.Text = "Open TCP Client";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 263);
            Controls.Add(btnClient);
            Controls.Add(btn_Server);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Server;
        private Button btnClient;
    }
}