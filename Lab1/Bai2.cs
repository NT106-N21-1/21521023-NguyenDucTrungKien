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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            float num1, num2, num3, max, min;
            int i = 1, j = 1, k = 1, count1 = 0, count2 = 0, count3 = 0, countDot1 = 0, countDot2 = 0, countDot3 = 0;
            if (txtNum1.Text[0] < 45 || (txtNum1.Text[0] > 45 && txtNum1.Text[0] < 48) || txtNum1.Text[0] > 57)
                count1++;
            if (txtNum2.Text[0] < 45 || (txtNum2.Text[0] > 45 && txtNum2.Text[0] < 48) || txtNum2.Text[0] > 57)
                count2++;
            if (txtNum3.Text[0] < 45 || (txtNum3.Text[0] > 45 && txtNum3.Text[0] < 48) || txtNum3.Text[0] > 57)
                count3++;
            while (i < txtNum1.Text.Length)
            {
                if (txtNum1.Text[i] < 46 || (txtNum1.Text[i] > 46 && txtNum1.Text[i] < 48) || txtNum1.Text[i] > 57)
                {
                    count1++;
                }
                if (txtNum1.Text[i] == 46)
                    countDot1++;
                i++;
            }
            while (j < txtNum2.Text.Length)
            {
                if (txtNum2.Text[j] < 46 || (txtNum2.Text[j] > 46 && txtNum2.Text[j] < 48) || txtNum2.Text[j] > 57)
                {
                    count2++;
                }
                if (txtNum2.Text[j] == 46)
                    countDot2++;
                j++;
            }
            while (k < txtNum3.Text.Length)
            {
                if (txtNum3.Text[k] < 46 || (txtNum3.Text[k] > 46 && txtNum3.Text[k] < 48) || txtNum3.Text[k] > 57)
                {
                    count3++;
                }
                if (txtNum3.Text[k] == 46)
                    countDot3++;
                k++;
            }
            if (count1 != 0 || count2 != 0 || count3 != 0 || countDot1 > 1 || countDot2 > 1 || countDot3 > 1)
                MessageBox.Show("Số không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                num1 = float.Parse(txtNum1.Text);
                num2 = float.Parse(txtNum2.Text);
                num3 = float.Parse(txtNum3.Text);
                if (num1 >= num2 && num1 >= num3)
                {
                    max = num1;
                }
                else if (num2 >= num1 && num2 >= num3)
                {
                    max = num2;
                }
                else
                    max = num3;
                if (num1 <= num2 && num1 <= num3)
                {
                    min = num1;
                }
                else if (num2 <= num1 && num2 <= num3)
                {
                    min = num2;
                }
                else
                    min = num3;
                txtMax.Text = max.ToString();
                txtMin.Text = min.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMax.Text = "";
            txtMin.Text = "";
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtNum3.Text = "";
        }
    }
}
