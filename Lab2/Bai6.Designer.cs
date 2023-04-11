namespace Lab2
{
    partial class Bai6
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
            treeView1 = new TreeView();
            grb_Contents = new GroupBox();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(259, 426);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // grb_Contents
            // 
            grb_Contents.Location = new Point(277, 12);
            grb_Contents.Name = "grb_Contents";
            grb_Contents.Size = new Size(511, 426);
            grb_Contents.TabIndex = 1;
            grb_Contents.TabStop = false;
            grb_Contents.Text = "File Content";
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grb_Contents);
            Controls.Add(treeView1);
            Name = "Bai6";
            Text = "Bai6";
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private GroupBox grb_Contents;
    }
}