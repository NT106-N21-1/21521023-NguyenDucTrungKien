namespace Lab4
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
            txtURL = new TextBox();
            txtFileURL = new TextBox();
            btnDownLoad = new Button();
            rtbShow = new RichTextBox();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(12, 12);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(676, 27);
            txtURL.TabIndex = 0;
            txtURL.Text = "https://";
            // 
            // txtFileURL
            // 
            txtFileURL.Location = new Point(12, 45);
            txtFileURL.Name = "txtFileURL";
            txtFileURL.Size = new Size(676, 27);
            txtFileURL.TabIndex = 1;
            // 
            // btnDownLoad
            // 
            btnDownLoad.Location = new Point(694, 12);
            btnDownLoad.Name = "btnDownLoad";
            btnDownLoad.Size = new Size(94, 29);
            btnDownLoad.TabIndex = 2;
            btnDownLoad.Text = "Download";
            btnDownLoad.UseVisualStyleBackColor = true;
            btnDownLoad.Click += btnDownLoad_Click;
            // 
            // rtbShow
            // 
            rtbShow.Location = new Point(12, 78);
            rtbShow.Name = "rtbShow";
            rtbShow.Size = new Size(776, 360);
            rtbShow.TabIndex = 3;
            rtbShow.Text = "";
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbShow);
            Controls.Add(btnDownLoad);
            Controls.Add(txtFileURL);
            Controls.Add(txtURL);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURL;
        private TextBox txtFileURL;
        private Button btnDownLoad;
        private RichTextBox rtbShow;
    }
}