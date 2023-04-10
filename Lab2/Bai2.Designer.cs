namespace Lab2
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
            btnRead = new Button();
            lblFileName = new Label();
            lblSize = new Label();
            lblURL = new Label();
            lblLineCount = new Label();
            lblWordCount = new Label();
            lblCharCount = new Label();
            txtFileName = new TextBox();
            txtSize = new TextBox();
            txtURL = new TextBox();
            txtLineCount = new TextBox();
            txtWordCount = new TextBox();
            txtCharCount = new TextBox();
            rtbShow = new RichTextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnRead.Location = new Point(12, 11);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(509, 47);
            btnRead.TabIndex = 0;
            btnRead.Text = "Read from File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(12, 123);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(73, 20);
            lblFileName.TabIndex = 1;
            lblFileName.Text = "File name";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(12, 156);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(36, 20);
            lblSize.TabIndex = 2;
            lblSize.Text = "Size";
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Location = new Point(12, 189);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(35, 20);
            lblURL.TabIndex = 3;
            lblURL.Text = "URL";
            // 
            // lblLineCount
            // 
            lblLineCount.AutoSize = true;
            lblLineCount.Location = new Point(12, 222);
            lblLineCount.Name = "lblLineCount";
            lblLineCount.Size = new Size(77, 20);
            lblLineCount.TabIndex = 4;
            lblLineCount.Text = "Line count";
            // 
            // lblWordCount
            // 
            lblWordCount.AutoSize = true;
            lblWordCount.Location = new Point(12, 255);
            lblWordCount.Name = "lblWordCount";
            lblWordCount.Size = new Size(88, 20);
            lblWordCount.TabIndex = 5;
            lblWordCount.Text = "Word Count";
            // 
            // lblCharCount
            // 
            lblCharCount.AutoSize = true;
            lblCharCount.Location = new Point(12, 288);
            lblCharCount.Name = "lblCharCount";
            lblCharCount.Size = new Size(113, 20);
            lblCharCount.TabIndex = 6;
            lblCharCount.Text = "Character count";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(181, 116);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(340, 27);
            txtFileName.TabIndex = 8;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(181, 149);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(340, 27);
            txtSize.TabIndex = 9;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(181, 182);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(340, 27);
            txtURL.TabIndex = 10;
            // 
            // txtLineCount
            // 
            txtLineCount.Location = new Point(181, 215);
            txtLineCount.Name = "txtLineCount";
            txtLineCount.Size = new Size(340, 27);
            txtLineCount.TabIndex = 11;
            // 
            // txtWordCount
            // 
            txtWordCount.Location = new Point(181, 248);
            txtWordCount.Name = "txtWordCount";
            txtWordCount.Size = new Size(340, 27);
            txtWordCount.TabIndex = 12;
            // 
            // txtCharCount
            // 
            txtCharCount.Location = new Point(181, 281);
            txtCharCount.Name = "txtCharCount";
            txtCharCount.Size = new Size(340, 27);
            txtCharCount.TabIndex = 13;
            // 
            // rtbShow
            // 
            rtbShow.Location = new Point(527, 12);
            rtbShow.Name = "rtbShow";
            rtbShow.ReadOnly = true;
            rtbShow.Size = new Size(469, 464);
            rtbShow.TabIndex = 14;
            rtbShow.Text = "";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(12, 429);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(509, 47);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 488);
            Controls.Add(rtbShow);
            Controls.Add(txtCharCount);
            Controls.Add(txtWordCount);
            Controls.Add(txtLineCount);
            Controls.Add(txtURL);
            Controls.Add(txtSize);
            Controls.Add(txtFileName);
            Controls.Add(lblCharCount);
            Controls.Add(lblWordCount);
            Controls.Add(lblLineCount);
            Controls.Add(lblURL);
            Controls.Add(lblSize);
            Controls.Add(lblFileName);
            Controls.Add(btnExit);
            Controls.Add(btnRead);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private Label lblFileName;
        private Label lblSize;
        private Label lblURL;
        private Label lblLineCount;
        private Label lblWordCount;
        private Label lblCharCount;
        private TextBox txtFileName;
        private TextBox txtSize;
        private TextBox txtURL;
        private TextBox txtLineCount;
        private TextBox txtWordCount;
        private TextBox txtCharCount;
        private RichTextBox rtbShow;
        private Button btnExit;
    }
}