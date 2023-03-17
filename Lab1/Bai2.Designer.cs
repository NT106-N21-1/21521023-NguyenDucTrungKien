namespace Lab1
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
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblNum3 = new Label();
            lblMax = new Label();
            lblMin = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtMax = new TextBox();
            txtMin = new TextBox();
            btnTim = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            txtNum3 = new TextBox();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(12, 57);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(105, 25);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Số thứ nhất";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(309, 57);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(93, 25);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "Số thứ hai";
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Location = new Point(606, 57);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(90, 25);
            lblNum3.TabIndex = 2;
            lblNum3.Text = "Số thứ ba";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(12, 326);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(103, 25);
            lblMax.TabIndex = 3;
            lblMax.Text = "Số lớn nhất";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(536, 329);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(98, 25);
            lblMin.TabIndex = 4;
            lblMin.Text = "Số bé nhất";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(123, 54);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(150, 31);
            txtNum1.TabIndex = 5;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(408, 54);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(150, 31);
            txtNum2.TabIndex = 6;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(123, 320);
            txtMax.Name = "txtMax";
            txtMax.ReadOnly = true;
            txtMax.Size = new Size(150, 31);
            txtMax.TabIndex = 11;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(640, 323);
            txtMin.Name = "txtMin";
            txtMin.ReadOnly = true;
            txtMin.Size = new Size(150, 31);
            txtMin.TabIndex = 12;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(120, 194);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(112, 34);
            btnTim.TabIndex = 8;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(678, 194);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(391, 194);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(702, 54);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(150, 31);
            txtNum3.TabIndex = 7;
            // 
            // Bai2
            // 
            AcceptButton = btnTim;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(880, 450);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(btnTim);
            Controls.Add(txtNum3);
            Controls.Add(txtMin);
            Controls.Add(txtMax);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblMin);
            Controls.Add(lblMax);
            Controls.Add(lblNum3);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "Bai2";
            Text = "Lab1_Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private Label lblNum3;
        private Label lblMax;
        private Label lblMin;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtNum3;
        private TextBox txtMax;
        private TextBox txtMin;
        private Button btnTim;
        private Button btnXoa;
        private Button btnThoat;
    }
}