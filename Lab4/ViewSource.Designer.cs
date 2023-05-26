namespace Lab4
{
    partial class ViewSource
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
            rtbShow = new RichTextBox();
            SuspendLayout();
            // 
            // rtbShow
            // 
            rtbShow.Dock = DockStyle.Fill;
            rtbShow.Location = new Point(0, 0);
            rtbShow.Name = "rtbShow";
            rtbShow.Size = new Size(800, 450);
            rtbShow.TabIndex = 0;
            rtbShow.Text = "";
            // 
            // ViewSource
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbShow);
            Name = "ViewSource";
            Text = "ViewSource";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbShow;
    }
}