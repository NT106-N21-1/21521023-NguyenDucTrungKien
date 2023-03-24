namespace Lab1
{
    partial class Bai3_1
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
            btnThoat = new Button();
            btnXoa = new Button();
            btnDoc = new Button();
            txtResult = new TextBox();
            txtNum = new TextBox();
            lblResult = new Label();
            lblNum = new Label();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(630, 305);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 60);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(630, 196);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 60);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(630, 86);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(120, 60);
            btnDoc.TabIndex = 11;
            btnDoc.Text = "Đọc";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(51, 308);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(286, 31);
            txtResult.TabIndex = 10;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(343, 92);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(150, 31);
            txtNum.TabIndex = 9;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(51, 261);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(79, 28);
            lblResult.TabIndex = 8;
            lblResult.Text = "Kết quả";
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblNum.Location = new Point(41, 92);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(296, 28);
            lblNum.TabIndex = 7;
            lblNum.Text = "Nhập vào số nguyên có 3 chữ số";
            // 
            // Bai3_1
            // 
            AcceptButton = btnDoc;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnDoc);
            Controls.Add(txtResult);
            Controls.Add(txtNum);
            Controls.Add(lblResult);
            Controls.Add(lblNum);
            Name = "Bai3_1";
            Text = "Bai3_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnXoa;
        private Button btnDoc;
        private TextBox txtResult;
        private TextBox txtNum;
        private Label lblResult;
        private Label lblNum;
    }
}