namespace Lab4
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
            txtURL = new TextBox();
            btnGet = new Button();
            rtbShow = new RichTextBox();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(12, 12);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(676, 27);
            txtURL.TabIndex = 0;
            // 
            // btnGet
            // 
            btnGet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGet.Location = new Point(694, 12);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(94, 29);
            btnGet.TabIndex = 1;
            btnGet.Text = "GET";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // rtbShow
            // 
            rtbShow.Location = new Point(12, 45);
            rtbShow.Name = "rtbShow";
            rtbShow.Size = new Size(776, 393);
            rtbShow.TabIndex = 2;
            rtbShow.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbShow);
            Controls.Add(btnGet);
            Controls.Add(txtURL);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURL;
        private Button btnGet;
        private RichTextBox rtbShow;
    }
}