namespace Lab1
{
    partial class Bai7
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
            lblDia_chi_mang = new Label();
            txtNum = new TextBox();
            lblSo_mang_con = new Label();
            btnChia_mang = new Button();
            ds_Mang = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            Diachimang = new DataGridViewTextBoxColumn();
            Diachidau = new DataGridViewTextBoxColumn();
            Diachicuoi = new DataGridViewTextBoxColumn();
            Diachibc = new DataGridViewTextBoxColumn();
            txt_NetIP = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ds_Mang).BeginInit();
            SuspendLayout();
            // 
            // lblDia_chi_mang
            // 
            lblDia_chi_mang.AutoSize = true;
            lblDia_chi_mang.Location = new Point(32, 45);
            lblDia_chi_mang.Name = "lblDia_chi_mang";
            lblDia_chi_mang.Size = new Size(97, 20);
            lblDia_chi_mang.TabIndex = 0;
            lblDia_chi_mang.Text = "Địa chỉ mạng";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(507, 42);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(126, 27);
            txtNum.TabIndex = 2;
            // 
            // lblSo_mang_con
            // 
            lblSo_mang_con.AutoSize = true;
            lblSo_mang_con.Location = new Point(347, 45);
            lblSo_mang_con.Name = "lblSo_mang_con";
            lblSo_mang_con.Size = new Size(154, 20);
            lblSo_mang_con.TabIndex = 3;
            lblSo_mang_con.Text = "Số mạng con cần chia";
            // 
            // btnChia_mang
            // 
            btnChia_mang.Location = new Point(639, 28);
            btnChia_mang.Name = "btnChia_mang";
            btnChia_mang.Size = new Size(94, 54);
            btnChia_mang.TabIndex = 4;
            btnChia_mang.Text = "Chia mạng";
            btnChia_mang.UseVisualStyleBackColor = true;
            btnChia_mang.Click += btnChia_mang_Click;
            // 
            // ds_Mang
            // 
            ds_Mang.AllowUserToAddRows = false;
            ds_Mang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ds_Mang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ds_Mang.Columns.AddRange(new DataGridViewColumn[] { STT, Diachimang, Diachidau, Diachicuoi, Diachibc });
            ds_Mang.Location = new Point(0, 104);
            ds_Mang.Name = "ds_Mang";
            ds_Mang.ReadOnly = true;
            ds_Mang.RowHeadersWidth = 51;
            ds_Mang.RowTemplate.Height = 29;
            ds_Mang.Size = new Size(800, 343);
            ds_Mang.TabIndex = 5;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Resizable = DataGridViewTriState.False;
            // 
            // Diachimang
            // 
            Diachimang.HeaderText = "Địa chỉ mạng";
            Diachimang.MinimumWidth = 6;
            Diachimang.Name = "Diachimang";
            Diachimang.ReadOnly = true;
            // 
            // Diachidau
            // 
            Diachidau.HeaderText = "Địa chỉ đầu";
            Diachidau.MinimumWidth = 6;
            Diachidau.Name = "Diachidau";
            Diachidau.ReadOnly = true;
            // 
            // Diachicuoi
            // 
            Diachicuoi.HeaderText = "Địa chỉ cuối";
            Diachicuoi.MinimumWidth = 6;
            Diachicuoi.Name = "Diachicuoi";
            Diachicuoi.ReadOnly = true;
            // 
            // Diachibc
            // 
            Diachibc.HeaderText = "Địa chỉ Broadcast";
            Diachibc.MinimumWidth = 6;
            Diachibc.Name = "Diachibc";
            Diachibc.ReadOnly = true;
            // 
            // txt_NetIP
            // 
            txt_NetIP.Location = new Point(135, 42);
            txt_NetIP.Name = "txt_NetIP";
            txt_NetIP.Size = new Size(167, 27);
            txt_NetIP.TabIndex = 1;
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 448);
            Controls.Add(ds_Mang);
            Controls.Add(btnChia_mang);
            Controls.Add(lblSo_mang_con);
            Controls.Add(txtNum);
            Controls.Add(txt_NetIP);
            Controls.Add(lblDia_chi_mang);
            Name = "Bai7";
            Text = "Bai7";
            ((System.ComponentModel.ISupportInitialize)ds_Mang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia_chi_mang;
        private TextBox txtNum;
        private Label lblSo_mang_con;
        private Button btnChia_mang;
        private DataGridView ds_Mang;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Diachimang;
        private DataGridViewTextBoxColumn Diachidau;
        private DataGridViewTextBoxColumn Diachicuoi;
        private DataGridViewTextBoxColumn Diachibc;
        private TextBox txt_NetIP;
    }
}