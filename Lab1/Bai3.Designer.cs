namespace Lab1
{
    partial class Bai3
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
            lblNum = new Label();
            lblResult = new Label();
            txtNum = new TextBox();
            txtResult = new TextBox();
            btnDoc = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNum.Location = new Point(18, 59);
            lblNum.Margin = new Padding(2, 0, 2, 0);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(251, 23);
            lblNum.TabIndex = 0;
            lblNum.Text = "Nhập vào số nguyên từ 0 đến 9";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(18, 194);
            lblResult.Margin = new Padding(2, 0, 2, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(69, 23);
            lblResult.TabIndex = 1;
            lblResult.Text = "Kết quả";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(273, 58);
            txtNum.Margin = new Padding(2, 2, 2, 2);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(121, 27);
            txtNum.TabIndex = 2;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(18, 232);
            txtResult.Margin = new Padding(2, 2, 2, 2);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(230, 27);
            txtResult.TabIndex = 3;
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(482, 54);
            btnDoc.Margin = new Padding(2, 2, 2, 2);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(96, 48);
            btnDoc.TabIndex = 4;
            btnDoc.Text = "Đọc";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(482, 142);
            btnXoa.Margin = new Padding(2, 2, 2, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(96, 48);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(482, 230);
            btnThoat.Margin = new Padding(2, 2, 2, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(96, 48);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Bai3
            // 
            AcceptButton = btnDoc;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(640, 360);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnDoc);
            Controls.Add(txtResult);
            Controls.Add(txtNum);
            Controls.Add(lblResult);
            Controls.Add(lblNum);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Bai3";
            Text = "Lab1_Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum;
        private Label lblResult;
        private TextBox txtNum;
        private TextBox txtResult;
        private Button btnDoc;
        private Button btnXoa;
        private Button btnThoat;
    }
}