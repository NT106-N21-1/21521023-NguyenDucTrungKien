namespace Lab2
{
    partial class Bai1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtxtShow = new RichTextBox();
            btnDocFile = new Button();
            btnGhiFile = new Button();
            SuspendLayout();
            // 
            // rtxtShow
            // 
            rtxtShow.Location = new Point(359, 12);
            rtxtShow.Name = "rtxtShow";
            rtxtShow.ReadOnly = true;
            rtxtShow.Size = new Size(429, 426);
            rtxtShow.TabIndex = 0;
            rtxtShow.Text = "";
            // 
            // btnDocFile
            // 
            btnDocFile.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnDocFile.Location = new Point(28, 12);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(270, 90);
            btnDocFile.TabIndex = 1;
            btnDocFile.Text = "ĐỌC FILE";
            btnDocFile.UseVisualStyleBackColor = true;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // btnGhiFile
            // 
            btnGhiFile.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnGhiFile.Location = new Point(28, 155);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(270, 90);
            btnGhiFile.TabIndex = 2;
            btnGhiFile.Text = "GHI FILE";
            btnGhiFile.UseVisualStyleBackColor = true;
            btnGhiFile.Click += btnGhiFile_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGhiFile);
            Controls.Add(btnDocFile);
            Controls.Add(rtxtShow);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtxtShow;
        private Button btnDocFile;
        private Button btnGhiFile;
    }
}