namespace Lab6
{
    partial class Form1
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
            gb_Show = new GroupBox();
            txtMaHoa = new RichTextBox();
            txtGiaiMa = new RichTextBox();
            txt_Input = new RichTextBox();
            txtShift = new TextBox();
            btnGiaiMa = new Button();
            btnMaHoa = new Button();
            lblGiaiMa = new Label();
            lbl_MaHoa = new Label();
            lbl_Input = new Label();
            lblShift = new Label();
            gb_Show.SuspendLayout();
            SuspendLayout();
            // 
            // gb_Show
            // 
            gb_Show.Controls.Add(txtMaHoa);
            gb_Show.Controls.Add(txtGiaiMa);
            gb_Show.Controls.Add(txt_Input);
            gb_Show.Controls.Add(txtShift);
            gb_Show.Controls.Add(btnGiaiMa);
            gb_Show.Controls.Add(btnMaHoa);
            gb_Show.Controls.Add(lblGiaiMa);
            gb_Show.Controls.Add(lbl_MaHoa);
            gb_Show.Controls.Add(lbl_Input);
            gb_Show.Controls.Add(lblShift);
            gb_Show.Dock = DockStyle.Fill;
            gb_Show.Location = new Point(0, 0);
            gb_Show.Name = "gb_Show";
            gb_Show.Size = new Size(584, 525);
            gb_Show.TabIndex = 0;
            gb_Show.TabStop = false;
            gb_Show.Text = "MÃ HÓA CAESAR";
            // 
            // txtMaHoa
            // 
            txtMaHoa.Location = new Point(12, 245);
            txtMaHoa.Name = "txtMaHoa";
            txtMaHoa.ReadOnly = true;
            txtMaHoa.Size = new Size(338, 120);
            txtMaHoa.TabIndex = 8;
            txtMaHoa.Text = "";
            // 
            // txtGiaiMa
            // 
            txtGiaiMa.Location = new Point(12, 391);
            txtGiaiMa.Name = "txtGiaiMa";
            txtGiaiMa.ReadOnly = true;
            txtGiaiMa.Size = new Size(338, 120);
            txtGiaiMa.TabIndex = 7;
            txtGiaiMa.Text = "";
            // 
            // txt_Input
            // 
            txt_Input.Location = new Point(12, 99);
            txt_Input.Name = "txt_Input";
            txt_Input.Size = new Size(338, 120);
            txt_Input.TabIndex = 6;
            txt_Input.Text = "";
            // 
            // txtShift
            // 
            txtShift.Location = new Point(12, 46);
            txtShift.Name = "txtShift";
            txtShift.Size = new Size(125, 27);
            txtShift.TabIndex = 5;
            // 
            // btnGiaiMa
            // 
            btnGiaiMa.Location = new Point(457, 26);
            btnGiaiMa.Name = "btnGiaiMa";
            btnGiaiMa.Size = new Size(94, 29);
            btnGiaiMa.TabIndex = 4;
            btnGiaiMa.Text = "GIẢI MÃ";
            btnGiaiMa.UseVisualStyleBackColor = true;
            btnGiaiMa.Click += btnGiaiMa_Click;
            // 
            // btnMaHoa
            // 
            btnMaHoa.Location = new Point(309, 26);
            btnMaHoa.Name = "btnMaHoa";
            btnMaHoa.Size = new Size(94, 29);
            btnMaHoa.TabIndex = 1;
            btnMaHoa.Text = "MÃ HÓA";
            btnMaHoa.UseVisualStyleBackColor = true;
            btnMaHoa.Click += btnMaHoa_Click;
            // 
            // lblGiaiMa
            // 
            lblGiaiMa.AutoSize = true;
            lblGiaiMa.Location = new Point(12, 368);
            lblGiaiMa.Name = "lblGiaiMa";
            lblGiaiMa.Size = new Size(60, 20);
            lblGiaiMa.TabIndex = 3;
            lblGiaiMa.Text = "Giải mã";
            // 
            // lbl_MaHoa
            // 
            lbl_MaHoa.AutoSize = true;
            lbl_MaHoa.Location = new Point(12, 222);
            lbl_MaHoa.Name = "lbl_MaHoa";
            lbl_MaHoa.Size = new Size(59, 20);
            lbl_MaHoa.TabIndex = 2;
            lbl_MaHoa.Text = "Mã hóa";
            // 
            // lbl_Input
            // 
            lbl_Input.AutoSize = true;
            lbl_Input.Location = new Point(12, 76);
            lbl_Input.Name = "lbl_Input";
            lbl_Input.Size = new Size(101, 20);
            lbl_Input.TabIndex = 1;
            lbl_Input.Text = "Dữ liệu(Input)";
            // 
            // lblShift
            // 
            lblShift.AutoSize = true;
            lblShift.Location = new Point(12, 23);
            lblShift.Name = "lblShift";
            lblShift.Size = new Size(79, 20);
            lblShift.TabIndex = 0;
            lblShift.Text = "Dịch(Shift)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 525);
            Controls.Add(gb_Show);
            Name = "Form1";
            Text = "Bài 1";
            gb_Show.ResumeLayout(false);
            gb_Show.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_Show;
        private Label lblGiaiMa;
        private Label lbl_MaHoa;
        private Label lbl_Input;
        private Label lblShift;
        private Button btnMaHoa;
        private RichTextBox txtMaHoa;
        private RichTextBox txtGiaiMa;
        private RichTextBox txt_Input;
        private TextBox txtShift;
        private Button btnGiaiMa;
    }
}