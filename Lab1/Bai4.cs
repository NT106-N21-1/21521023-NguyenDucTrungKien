using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (cbXe.Text == "" || cbXang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((cbXe.Text == "Wave Alpha" && cbXang.Text == "Dầu DO 0,05S-II") || (cbXe.Text == "Sirius" && cbXang.Text == "Dầu DO 0,05S-II") || (cbXe.Text == "Vision" && cbXang.Text == "Dầu DO 0,05S-II") || (cbXe.Text == "Lead" && cbXang.Text == "Dầu DO 0,05S-II") || (cbXe.Text == "Lead" && cbXang.Text == "Xăng E5 RON 92-II") || (cbXe.Text == "Winner" && cbXang.Text == "Dầu DO 0,05S-II") || (cbXe.Text == "Winner" && cbXang.Text == "Xăng E5 RON 92-II") || (cbXe.Text == "AirBlade 150" && cbXang.Text == "Dầu DO 0,05S-II") || (cbXe.Text == "AirBlade 150" && cbXang.Text == "Xăng E5 RON 92-II") || (cbXe.Text == "Xe tải 9 tấn" && cbXang.Text == "Xăng RON 95-III") || (cbXe.Text == "Xe tải 9 tấn" && cbXang.Text == "Xăng E5 RON 92-II"))
            {
                txtKhoangCach.Text = "";
                txtTien.Text = "";
                MessageBox.Show("Xe không sử dụng loại xăng/dầu này. Vui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double gia = 0;
                double succhua = 0;
                double tieuton = 0;
                double khoangcach = 0;
                double tongtien = 0;
                switch (cbXe.Text)
                {
                    case "Wave Alpha":
                        {
                            succhua = 3.7;
                            tieuton = 1.6;
                            break;
                        }
                    case "Sirius":
                        {
                            succhua = 3.8;
                            tieuton = 1.99;
                            break;
                        }
                    case "Vision":
                        {
                            succhua = 5.2;
                            tieuton = 1.87;
                            break;
                        }
                    case "Lead":
                        {
                            succhua = 6;
                            tieuton = 2.02;
                            break;
                        }
                    case "Winner":
                        {
                            succhua = 4.5;
                            tieuton = 1.7;
                            break;
                        }

                    case "AirBlade 150":
                        {
                            succhua = 4.4;
                            tieuton = 2.17;
                            break;
                        }
                    case "Xe tải 9 tấn":
                        {
                            succhua = 70;
                            tieuton = 13;
                            break;
                        }
                }
                switch (cbXang.Text)
                {
                    case "Xăng RON 95-III":
                        {
                            gia = 26830;
                            break;
                        }
                    case "Xăng E5 RON 92-II":
                        {
                            gia = 26070;
                            break;
                        }
                    case "Dầu DO 0,05S-II":
                        {
                            gia = 21310;
                            break;
                        }
                }
                khoangcach = Math.Round((succhua * 100) / tieuton, 3);
                tongtien = Math.Round(gia * succhua);
                txtKhoangCach.Text = khoangcach.ToString();
                txtTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tongtien);
            }
        }
    }
}
