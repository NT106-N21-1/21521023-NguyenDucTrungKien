namespace Lab4
{
    partial class Bai4
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
            txtURL = new TextBox();
            btnShow = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            btnDownload = new Button();
            btnGet = new Button();
            txtFileURL = new TextBox();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(12, 12);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(576, 27);
            txtURL.TabIndex = 0;
            txtURL.Text = "https:\\\\";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(594, 12);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 78);
            webView21.Name = "webView21";
            webView21.Size = new Size(776, 360);
            webView21.TabIndex = 2;
            webView21.ZoomFactor = 1D;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(494, 43);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(94, 29);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(694, 12);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(94, 29);
            btnGet.TabIndex = 1;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtFileURL
            // 
            txtFileURL.Location = new Point(12, 45);
            txtFileURL.Name = "txtFileURL";
            txtFileURL.Size = new Size(476, 27);
            txtFileURL.TabIndex = 0;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webView21);
            Controls.Add(btnGet);
            Controls.Add(btnDownload);
            Controls.Add(btnShow);
            Controls.Add(txtFileURL);
            Controls.Add(txtURL);
            Name = "Bai4";
            Text = "Bai4";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURL;
        private Button btnShow;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button btnDownload;
        private Button btnGet;
        private TextBox txtFileURL;
    }
}