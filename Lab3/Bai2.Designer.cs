namespace Lab3
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
            lv_Show = new ListView();
            btnListen = new Button();
            SuspendLayout();
            // 
            // lv_Show
            // 
            lv_Show.Location = new Point(12, 76);
            lv_Show.Name = "lv_Show";
            lv_Show.Size = new Size(505, 289);
            lv_Show.TabIndex = 0;
            lv_Show.UseCompatibleStateImageBehavior = false;
            lv_Show.View = View.List;
            // 
            // btnListen
            // 
            btnListen.Location = new Point(12, 27);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(129, 29);
            btnListen.TabIndex = 1;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 377);
            Controls.Add(btnListen);
            Controls.Add(lv_Show);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
        }

        #endregion

        private ListView lv_Show;
        private Button btnListen;
    }
}