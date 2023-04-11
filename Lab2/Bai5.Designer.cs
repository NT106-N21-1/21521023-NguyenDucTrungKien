namespace Lab2
{
    partial class Bai5
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
            btnNen = new Button();
            btnGiaiNen = new Button();
            rtbShow = new RichTextBox();
            SuspendLayout();
            // 
            // btnNen
            // 
            btnNen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNen.Location = new Point(12, 12);
            btnNen.Name = "btnNen";
            btnNen.Size = new Size(250, 130);
            btnNen.TabIndex = 0;
            btnNen.Text = "Nén và lưu file";
            btnNen.UseVisualStyleBackColor = true;
            btnNen.Click += btnNen_Click;
            // 
            // btnGiaiNen
            // 
            btnGiaiNen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiaiNen.Location = new Point(12, 308);
            btnGiaiNen.Name = "btnGiaiNen";
            btnGiaiNen.Size = new Size(250, 130);
            btnGiaiNen.TabIndex = 1;
            btnGiaiNen.Text = "Giải nén file";
            btnGiaiNen.UseVisualStyleBackColor = true;
            btnGiaiNen.Click += btnGiaiNen_Click;
            // 
            // rtbShow
            // 
            rtbShow.Location = new Point(268, 12);
            rtbShow.Name = "rtbShow";
            rtbShow.Size = new Size(520, 426);
            rtbShow.TabIndex = 3;
            rtbShow.Text = "";
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbShow);
            Controls.Add(btnGiaiNen);
            Controls.Add(btnNen);
            Name = "Bai5";
            Text = "Bai5";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNen;
        private Button btnGiaiNen;
        private RichTextBox rtbShow;
    }
}