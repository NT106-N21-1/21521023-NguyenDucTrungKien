using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            int num, count = 0;
            for (int i = 0; i < txtNum.Text.Length; i++)
            {
                if (txtNum.Text[i] < 48 || txtNum.Text[i] > 57)
                    count++;
            }
            if (count != 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "";
            }
            else
            {
                num = int.Parse(txtNum.Text);
                if (num < 0 || num > 9)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtResult.Text = " ";
                }
                else
                {
                    switch (num)
                    {
                        case 0:
                            {
                                txtResult.Text = "Không";
                                break;
                            }
                        case 1:
                            {
                                txtResult.Text = "Một";
                                break;
                            }
                        case 2:
                            {
                                txtResult.Text = "Hai";
                                break;
                            }
                        case 3:
                            {
                                txtResult.Text = "Ba";
                                break;
                            }
                        case 4:
                            {
                                txtResult.Text = "Bốn";
                                break;
                            }
                        case 5:
                            {
                                txtResult.Text = "Năm";
                                break;
                            }
                        case 6:
                            {
                                txtResult.Text = "Sáu";
                                break;
                            }
                        case 7:
                            {
                                txtResult.Text = "Bảy";
                                break;
                            }
                        case 8:
                            {
                                txtResult.Text = "Tám";
                                break;
                            }
                        case 9:
                            {
                                txtResult.Text = "Chín";
                                break;
                            }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
            txtResult.Text = "";
        }
    }
}
