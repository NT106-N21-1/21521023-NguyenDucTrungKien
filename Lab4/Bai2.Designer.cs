namespace Lab4
{
    partial class Bai2
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
            btnPost = new Button();
            txtURL = new TextBox();
            txtData = new TextBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnPost
            // 
            btnPost.Location = new Point(694, 12);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(94, 29);
            btnPost.TabIndex = 0;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(12, 12);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(676, 27);
            txtURL.TabIndex = 1;
            // 
            // txtData
            // 
            txtData.Location = new Point(12, 45);
            txtData.Name = "txtData";
            txtData.Size = new Size(451, 27);
            txtData.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 78);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 360);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(txtData);
            Controls.Add(txtURL);
            Controls.Add(btnPost);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPost;
        private TextBox txtURL;
        private TextBox txtData;
        private RichTextBox richTextBox1;
    }
}