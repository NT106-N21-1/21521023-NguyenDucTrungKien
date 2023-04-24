namespace Lab3
{
    partial class Bai3_Server
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
            btnListen = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.Location = new Point(12, 40);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(94, 29);
            btnListen.TabIndex = 0;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 118);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 320);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // Bai3_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(btnListen);
            Name = "Bai3_Server";
            Text = "TCP Server";
            ResumeLayout(false);
        }

        #endregion

        private Button btnListen;
        private RichTextBox richTextBox1;
    }
}