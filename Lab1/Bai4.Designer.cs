namespace Lab1
{
    partial class Bai4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai4));
            lblXe = new Label();
            lblXang = new Label();
            lblKhoangCach = new Label();
            lblTien = new Label();
            cbXe = new ComboBox();
            cbXang = new ComboBox();
            btnTinh = new Button();
            txtKhoangCach = new TextBox();
            txtTien = new TextBox();
            lbl_Info_Xe = new Label();
            lbl_Info_Xang = new Label();
            lbl_Donvi_km = new Label();
            lbl_Donvi_VND = new Label();
            SuspendLayout();
            // 
            // lblXe
            // 
            lblXe.AutoSize = true;
            lblXe.Location = new Point(107, 40);
            lblXe.Name = "lblXe";
            lblXe.Size = new Size(59, 20);
            lblXe.TabIndex = 0;
            lblXe.Text = "Loại xe:";
            // 
            // lblXang
            // 
            lblXang.AutoSize = true;
            lblXang.Location = new Point(61, 87);
            lblXang.Name = "lblXang";
            lblXang.Size = new Size(105, 20);
            lblXang.TabIndex = 1;
            lblXang.Text = "Loại xăng dầu:";
            // 
            // lblKhoangCach
            // 
            lblKhoangCach.AutoSize = true;
            lblKhoangCach.Location = new Point(58, 282);
            lblKhoangCach.Name = "lblKhoangCach";
            lblKhoangCach.Size = new Size(108, 20);
            lblKhoangCach.TabIndex = 2;
            lblKhoangCach.Text = "Số km đi được:";
            // 
            // lblTien
            // 
            lblTien.AutoSize = true;
            lblTien.Location = new Point(59, 334);
            lblTien.Name = "lblTien";
            lblTien.Size = new Size(107, 20);
            lblTien.TabIndex = 3;
            lblTien.Text = "Số tiền cần trả:";
            // 
            // cbXe
            // 
            cbXe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbXe.FormattingEnabled = true;
            cbXe.Items.AddRange(new object[] { "Wave Alpha", "Sirius", "Vision", "Lead", "Winner", "AirBlade 150", "Xe tải 9 tấn" });
            cbXe.Location = new Point(172, 37);
            cbXe.Name = "cbXe";
            cbXe.Size = new Size(151, 28);
            cbXe.TabIndex = 4;
            // 
            // cbXang
            // 
            cbXang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbXang.FormattingEnabled = true;
            cbXang.Items.AddRange(new object[] { "Xăng RON 95-III", "Xăng E5 RON 92-II", "Dầu DO 0,05S-II" });
            cbXang.Location = new Point(172, 84);
            cbXang.Name = "cbXang";
            cbXang.Size = new Size(151, 28);
            cbXang.TabIndex = 5;
            // 
            // btnTinh
            // 
            btnTinh.BackColor = SystemColors.ActiveBorder;
            btnTinh.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnTinh.Location = new Point(75, 158);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(282, 50);
            btnTinh.TabIndex = 6;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = false;
            btnTinh.Click += btnTinh_Click;
            // 
            // txtKhoangCach
            // 
            txtKhoangCach.Location = new Point(172, 279);
            txtKhoangCach.Name = "txtKhoangCach";
            txtKhoangCach.ReadOnly = true;
            txtKhoangCach.Size = new Size(151, 27);
            txtKhoangCach.TabIndex = 7;
            // 
            // txtTien
            // 
            txtTien.Location = new Point(172, 331);
            txtTien.Name = "txtTien";
            txtTien.ReadOnly = true;
            txtTien.Size = new Size(151, 27);
            txtTien.TabIndex = 8;
            // 
            // lbl_Info_Xe
            // 
            lbl_Info_Xe.AutoSize = true;
            lbl_Info_Xe.Location = new Point(449, 37);
            lbl_Info_Xe.Name = "lbl_Info_Xe";
            lbl_Info_Xe.Size = new Size(537, 160);
            lbl_Info_Xe.TabIndex = 11;
            lbl_Info_Xe.Text = resources.GetString("lbl_Info_Xe.Text");
            // 
            // lbl_Info_Xang
            // 
            lbl_Info_Xang.AutoSize = true;
            lbl_Info_Xang.Location = new Point(450, 279);
            lbl_Info_Xang.Name = "lbl_Info_Xang";
            lbl_Info_Xang.Size = new Size(266, 80);
            lbl_Info_Xang.TabIndex = 12;
            lbl_Info_Xang.Text = "Thông tin tỉ giá xăng dầu:\r\n    - Xăng RON 95-III: 26,830 đồng/lít\r\n    - Xăng E5 RON 92-II: 26,070 đồng/lít\r\n    - Dầu DO 0,05S-II: 21,310 đồng/lít";
            // 
            // lbl_Donvi_km
            // 
            lbl_Donvi_km.AutoSize = true;
            lbl_Donvi_km.Location = new Point(329, 282);
            lbl_Donvi_km.Name = "lbl_Donvi_km";
            lbl_Donvi_km.Size = new Size(39, 20);
            lbl_Donvi_km.TabIndex = 13;
            lbl_Donvi_km.Text = "(km)";
            // 
            // lbl_Donvi_VND
            // 
            lbl_Donvi_VND.AutoSize = true;
            lbl_Donvi_VND.Location = new Point(329, 334);
            lbl_Donvi_VND.Name = "lbl_Donvi_VND";
            lbl_Donvi_VND.Size = new Size(50, 20);
            lbl_Donvi_VND.TabIndex = 13;
            lbl_Donvi_VND.Text = "(VNĐ)";
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 410);
            Controls.Add(lbl_Donvi_VND);
            Controls.Add(lbl_Donvi_km);
            Controls.Add(lbl_Info_Xang);
            Controls.Add(lbl_Info_Xe);
            Controls.Add(txtTien);
            Controls.Add(txtKhoangCach);
            Controls.Add(btnTinh);
            Controls.Add(cbXang);
            Controls.Add(cbXe);
            Controls.Add(lblTien);
            Controls.Add(lblKhoangCach);
            Controls.Add(lblXang);
            Controls.Add(lblXe);
            Name = "Bai4";
            Text = "Bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblXe;
        private Label lblXang;
        private Label lblKhoangCach;
        private Label lblTien;
        private ComboBox cbXe;
        private ComboBox cbXang;
        private Button btnTinh;
        private TextBox txtKhoangCach;
        private TextBox txtTien;
        private Label lblXangInfo;
        private Label label6;
        private Label lbl_Info_Xe;
        private Label lbl_Info_Xang;
        private Label label8;
        private Label lbl_Donvi_km;
        private Label lbl_Donvi_VND;
    }
}