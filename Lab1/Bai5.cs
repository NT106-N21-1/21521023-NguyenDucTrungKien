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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0, count1 = 0, count2 = 0;
            int numA, numB;
            long giaithua_A = 1, giaithua_B = 1, s1 = 0, s2 = 0, s3 = 0;
            while (i < txtSoA.Text.Length)
            {
                if (txtSoA.Text[i] < 48 || txtSoA.Text[i] > 57)
                {
                    count1++;
                }
                i++;
            }
            while (j < txtSoB.Text.Length)
            {
                if (txtSoB.Text[j] < 48 || txtSoB.Text[j] > 57)
                {
                    count2++;
                }
                j++;
            }
            if (count1 != 0 || count2 != 0)
            {
                txtSoA.Text = "";
                txtSoB.Text = "";
                lblGiaiThua_A.Text = "";
                lblGiaithua_B.Text = "";
                lbl_S1.Text = "";
                lbl_S2.Text = "";
                lbl_S3.Text = "";
                MessageBox.Show("Vui lòng nhập số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtSoA.Text == "" || txtSoB.Text == "")
            {
                txtSoA.Text = "";
                txtSoB.Text = "";
                lblGiaiThua_A.Text = "";
                lblGiaithua_B.Text = "";
                lbl_S1.Text = "";
                lbl_S2.Text = "";
                lbl_S3.Text = "";
                MessageBox.Show("Vui lòng nhập số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else
            {
                numA = int.Parse(txtSoA.Text);
                numB = int.Parse(txtSoB.Text);
                for (int n1 = numA; n1 > 0; n1--)
                {
                    giaithua_A *= n1;
                    s1 += n1;
                }
                for (int n2 = numB; n2 > 0; n2--)
                {
                    giaithua_B *= n2;
                    s2 += n2;
                    s3 += (long)Math.Pow(numA, n2);
                }
                lblGiaiThua_A.Text = "A! = " + giaithua_A.ToString();
                lblGiaithua_B.Text = "B! = " + giaithua_B.ToString();
                lbl_S1.Text = "S1 = 1 + 2 + 3 + 4 + ... + A = " + s1.ToString();
                lbl_S2.Text = "S2 = 1 + 2 + 3 + 4 + ... + B = " + s2.ToString();
                lbl_S3.Text = "A^1 + A^2 + A^3 + A^4 + ... + A^B = " + s3.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            lblGiaiThua_A.Text = "";
            lblGiaithua_B.Text = "";
            lbl_S1.Text = "";
            lbl_S2.Text = "";
            lbl_S3.Text = "";
        }
    }
}
