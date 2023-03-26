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
    public partial class Bai3_1 : Form
    {
        public Bai3_1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string Doc(int num)
        {
            string strNum = "";
            switch (num)
            {
                case 0:
                    {
                        strNum = "Không";
                        break;
                    }
                case 1:
                    {
                        strNum = "Một";
                        break;
                    }
                case 2:
                    {
                        strNum = "Hai";
                        break;
                    }
                case 3:
                    {
                        strNum = "Ba";
                        break;
                    }
                case 4:
                    {
                        strNum = "Bốn";
                        break;
                    }
                case 5:
                    {
                        strNum = "Năm";
                        break;
                    }
                case 6:
                    {
                        strNum = "Sáu";
                        break;
                    }
                case 7:
                    {
                        strNum = "Bảy";
                        break;
                    }
                case 8:
                    {
                        strNum = "Tám";
                        break;
                    }
                case 9:
                    {
                        strNum = "Chín";
                        break;
                    }
            }
            return strNum;
        }
        private void btnDoc_Click(object sender, EventArgs e)
        {
            int num, count = 0, cChar = 0;
            for (int i = 0; i < txtNum.Text.Length; i++)
            {
                if (txtNum.Text[i] < 48 || txtNum.Text[i] > 57)
                    cChar++;
                count++;
            }
            if (cChar != 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên có 3 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "";
            }
            else if (count > 3)
            {
                MessageBox.Show("Vui lòng nhập số nguyên có 3 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "";
            }
            else if (txtNum.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số nguyên có 3 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "";
            }
            else
            {
                num = int.Parse(txtNum.Text);
                if (num < 0 || num > 999)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên có 3 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtResult.Text = "";
                }
                else
                {
                    int cNum = 0;
                    int lNum = num;
                    while (cNum < txtNum.Text.Length)
                    {
                        cNum++;
                    }
                    int[] sNum = new int[cNum];
                    for (int i = cNum - 1; i >= 0; i--)
                    {
                        sNum[i] = lNum % 10;
                        lNum = lNum / 10;
                    }
                    if (cNum == 1)
                    {
                        for (int j = 0; j < cNum; j++)
                        {
                            txtResult.Text = Doc(sNum[j]);
                        }
                    }
                    else if (cNum == 2)
                    {
                        if (sNum[0] == 0)
                        {
                            txtResult.Text = Doc(sNum[1]);
                        }
                        else if (sNum[0] != 0)
                        {
                            if (sNum[1] == 0)
                            {
                                if (sNum[0] == 1)
                                    txtResult.Text = "Mười";
                                else
                                {
                                    txtResult.Text = Doc(sNum[0]) + " mươi";
                                }
                            }
                            else
                            {
                                if (sNum[0] == 1)
                                {
                                    if (sNum[1] == 5)
                                        txtResult.Text = "Mười lăm";
                                    else
                                        txtResult.Text = "Mười " + Doc(sNum[1]).ToLower();
                                }
                                else
                                {
                                    if (sNum[1] == 5)
                                        txtResult.Text = Doc(sNum[0]) + " mươi lăm";
                                    else if (sNum[1] == 1)
                                        txtResult.Text = Doc(sNum[0]) + " mươi mốt";
                                    else
                                        txtResult.Text = Doc(sNum[0]) + " mươi " + Doc(sNum[1]).ToLower();
                                }
                            }
                        }
                    }
                    else
                    {
                        if (sNum[0] == 0)
                        {
                            if (sNum[1] == 0)
                            {
                                txtResult.Text = Doc(sNum[2]);
                            }
                            else if (sNum[1] != 0)
                            {
                                if (sNum[2] == 0)
                                {
                                    if (sNum[1] == 1)
                                        txtResult.Text = "Mười";
                                    else
                                    {
                                        txtResult.Text = Doc(sNum[1]) + " mươi";
                                    }
                                }
                                else
                                {
                                    if (sNum[1] == 1)
                                    {
                                        if (sNum[2] == 5)
                                            txtResult.Text = "Mười lăm";
                                        else
                                            txtResult.Text = "Mười " + Doc(sNum[2]).ToLower();
                                    }
                                    else
                                    {
                                        if (sNum[2] == 5)
                                            txtResult.Text = Doc(sNum[1]) + " mươi lăm";
                                        else if (sNum[2] == 1)
                                            txtResult.Text = Doc(sNum[1]) + " mươi mốt";
                                        else
                                            txtResult.Text = Doc(sNum[1]) + " mươi " + Doc(sNum[2]).ToLower();
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (sNum[1] == 0)
                            {
                                if (sNum[2] == 0)
                                    txtResult.Text = Doc(sNum[0]) + " trăm";
                                else
                                    txtResult.Text = Doc(sNum[0]) + " trăm lẻ " + Doc(sNum[2]).ToLower();
                            }
                            else if (sNum[1] == 1)
                            {
                                if (sNum[2] == 0)
                                    txtResult.Text = Doc(sNum[0]) + " trăm mười";
                                else if (sNum[2] == 5)
                                    txtResult.Text = Doc(sNum[0]) + " trăm mười lăm";
                                else
                                    txtResult.Text = Doc(sNum[0]) + " trăm mười " + Doc(sNum[2]).ToLower();
                            }
                            else
                            {
                                if (sNum[2] == 0)
                                    txtResult.Text = Doc(sNum[0]) + " trăm " + Doc(sNum[1]).ToLower() + " mươi";
                                else if (sNum[2] == 1)
                                    txtResult.Text = Doc(sNum[0]) + " trăm " + Doc(sNum[1]).ToLower() + " mươi mốt";
                                else if (sNum[2] == 5)
                                    txtResult.Text = Doc(sNum[0]) + " trăm " + Doc(sNum[1]).ToLower() + " mươi lăm";
                                else
                                    txtResult.Text = Doc(sNum[0]) + " trăm " + Doc(sNum[1]).ToLower() + " mươi " + Doc(sNum[2]).ToLower();
                            }
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
