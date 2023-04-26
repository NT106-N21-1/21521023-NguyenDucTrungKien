namespace LAB03_BAI04
{
    partial class Sever
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
            this.listenBT = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listenBT
            // 
            this.listenBT.Location = new System.Drawing.Point(264, 12);
            this.listenBT.Name = "listenBT";
            this.listenBT.Size = new System.Drawing.Size(120, 30);
            this.listenBT.TabIndex = 1;
            this.listenBT.Text = "Start Listen \r\n";
            this.listenBT.UseVisualStyleBackColor = true;
            this.listenBT.Click += new System.EventHandler(this.listenBT_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(353, 295);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Sever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 376);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listenBT);
            this.Name = "Sever";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion
        private Button listenBT;
        private ListBox severLB;
        private Button button1;
        private RichTextBox richTextBox1;
    }
}