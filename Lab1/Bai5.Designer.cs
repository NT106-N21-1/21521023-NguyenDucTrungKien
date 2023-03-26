namespace Lab1
{
    partial class Bai5
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
            lblSoA = new Label();
            lblSoB = new Label();
            btnTinh = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            gbKetqua = new GroupBox();
            lblGiaithua_B = new Label();
            lbl_S2 = new Label();
            lbl_S3 = new Label();
            lbl_S1 = new Label();
            lblGiaiThua_A = new Label();
            txtSoA = new TextBox();
            txtSoB = new TextBox();
            gbKetqua.SuspendLayout();
            SuspendLayout();
            // 
            // lblSoA
            // 
            lblSoA.AutoSize = true;
            lblSoA.Location = new Point(40, 54);
            lblSoA.Name = "lblSoA";
            lblSoA.Size = new Size(59, 20);
            lblSoA.TabIndex = 0;
            lblSoA.Text = "Nhập A";
            // 
            // lblSoB
            // 
            lblSoB.AutoSize = true;
            lblSoB.Location = new Point(493, 54);
            lblSoB.Name = "lblSoB";
            lblSoB.Size = new Size(58, 20);
            lblSoB.TabIndex = 1;
            lblSoB.Text = "Nhập B";
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(40, 138);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(298, 55);
            btnTinh.TabIndex = 2;
            btnTinh.Text = "Tính các giá trị";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(404, 138);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 55);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(588, 138);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 55);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // gbKetqua
            // 
            gbKetqua.Controls.Add(lblGiaithua_B);
            gbKetqua.Controls.Add(lbl_S2);
            gbKetqua.Controls.Add(lbl_S3);
            gbKetqua.Controls.Add(lbl_S1);
            gbKetqua.Controls.Add(lblGiaiThua_A);
            gbKetqua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbKetqua.Location = new Point(40, 246);
            gbKetqua.Name = "gbKetqua";
            gbKetqua.Size = new Size(642, 181);
            gbKetqua.TabIndex = 5;
            gbKetqua.TabStop = false;
            gbKetqua.Text = "KẾT QUẢ";
            // 
            // lblGiaithua_B
            // 
            lblGiaithua_B.AutoSize = true;
            lblGiaithua_B.Location = new Point(395, 30);
            lblGiaithua_B.Name = "lblGiaithua_B";
            lblGiaithua_B.Size = new Size(0, 20);
            lblGiaithua_B.TabIndex = 0;
            // 
            // lbl_S2
            // 
            lbl_S2.AutoSize = true;
            lbl_S2.Location = new Point(22, 104);
            lbl_S2.Name = "lbl_S2";
            lbl_S2.Size = new Size(0, 20);
            lbl_S2.TabIndex = 0;
            // 
            // lbl_S3
            // 
            lbl_S3.AutoSize = true;
            lbl_S3.Location = new Point(22, 142);
            lbl_S3.Name = "lbl_S3";
            lbl_S3.Size = new Size(0, 20);
            lbl_S3.TabIndex = 0;
            // 
            // lbl_S1
            // 
            lbl_S1.AutoSize = true;
            lbl_S1.Location = new Point(22, 67);
            lbl_S1.Name = "lbl_S1";
            lbl_S1.Size = new Size(0, 20);
            lbl_S1.TabIndex = 0;
            // 
            // lblGiaiThua_A
            // 
            lblGiaiThua_A.AutoSize = true;
            lblGiaiThua_A.Location = new Point(22, 30);
            lblGiaiThua_A.Name = "lblGiaiThua_A";
            lblGiaiThua_A.Size = new Size(0, 20);
            lblGiaiThua_A.TabIndex = 0;
            // 
            // txtSoA
            // 
            txtSoA.Location = new Point(105, 51);
            txtSoA.Name = "txtSoA";
            txtSoA.Size = new Size(125, 27);
            txtSoA.TabIndex = 6;
            // 
            // txtSoB
            // 
            txtSoB.Location = new Point(557, 51);
            txtSoB.Name = "txtSoB";
            txtSoB.Size = new Size(125, 27);
            txtSoB.TabIndex = 6;
            // 
            // Bai5
            // 
            AcceptButton = btnTinh;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSoB);
            Controls.Add(txtSoA);
            Controls.Add(gbKetqua);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTinh);
            Controls.Add(lblSoB);
            Controls.Add(lblSoA);
            Name = "Bai5";
            Text = "Bai5";
            gbKetqua.ResumeLayout(false);
            gbKetqua.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSoA;
        private Label lblSoB;
        private Button btnTinh;
        private Button btnXoa;
        private Button btnThoat;
        private GroupBox gbKetqua;
        private TextBox txtSoA;
        private TextBox txtSoB;
        private Label lblGiaithua_B;
        private Label lbl_S2;
        private Label lbl_S3;
        private Label lbl_S1;
        private Label lblGiaiThua_A;
    }
}