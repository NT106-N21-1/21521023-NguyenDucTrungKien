﻿namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0, count1 = 0, count2 = 0;
            int num1, num2;
            long result;
            while (i < txtNum1.Text.Length)
            {
                if (txtNum1.Text[i] < 48 || txtNum1.Text[i] > 57)
                {
                    count1++;
                }
                i++;
            }
            while (j < txtNum2.Text.Length)
            {
                if (txtNum2.Text[j] < 48 || txtNum2.Text[j] > 57)
                {
                    count2++;
                }
                j++;
            }
            if (count1 != 0 || count2 != 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                num1 = Int32.Parse(txtNum1.Text);
                num2 = Int32.Parse(txtNum2.Text);
                result = num1 + num2;
                txtResult.Text = result.ToString();
            }
        }
    }
}