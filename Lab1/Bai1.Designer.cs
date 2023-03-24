namespace Lab1
{
    partial class Bai1
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
            lblHeader = new Label();
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblKetQua = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtResult = new TextBox();
            btnTinh = new Button();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.Red;
            lblHeader.Location = new Point(251, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(340, 36);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "TÍNH TỔNG 2 SỐ NGUYÊN";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(59, 97);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(105, 25);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "Số thứ nhất";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(59, 157);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(93, 25);
            lblNum2.TabIndex = 2;
            lblNum2.Text = "Số thứ hai";
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(69, 264);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(72, 25);
            lblKetQua.TabIndex = 3;
            lblKetQua.Text = "Kết quả";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(170, 97);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(304, 31);
            txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(170, 157);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(304, 31);
            txtNum2.TabIndex = 5;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(170, 264);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(304, 31);
            txtResult.TabIndex = 6;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(356, 194);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(118, 64);
            btnTinh.TabIndex = 7;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // Bai1
            // 
            AcceptButton = btnTinh;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 429);
            Controls.Add(btnTinh);
            Controls.Add(txtResult);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblKetQua);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(lblHeader);
            Name = "Bai1";
            Text = "Lab1_Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblKetQua;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResult;
        private Button btnTinh;
    }
}