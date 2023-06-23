using System;
using System.Runtime;
namespace Lab6
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            int countChar = 0;
            txtMaHoa.Text = "";
            txtGiaiMa.Text = "";
            if (txtShift.Text == "" || txt_Input.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtShift.Text != "")
            {
                int countWrongShift = 0;
                for (int i = 0; i < txtShift.Text.Length; i++)
                {
                    if (txtShift.Text[i] < 48 || txtShift.Text[i] > 57)
                        countWrongShift++;
                }
                if (countWrongShift != 0)
                    MessageBox.Show("Số ký tự cần dịch không đúng. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    string encodedString = txt_Input.Text;
                    char[] upperChar = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                    for (int i = 0; i < encodedString.Length; i++)
                    {
                        countChar = 0;
                        for (int j = 0; j < 26; j++)
                        {
                            if (encodedString[i].ToString().ToUpper() == upperChar[j].ToString())
                            {
                                countChar++;
                                if (char.IsLower(encodedString[i]) == true)
                                    txtMaHoa.Text += upperChar[(j + int.Parse(txtShift.Text)) % 26].ToString().ToLower();
                                else
                                    txtMaHoa.Text += upperChar[(j + int.Parse(txtShift.Text)) % 26];
                            }
                        }
                        if (countChar == 0)
                            txtMaHoa.Text += encodedString[i];

                    }
                }
            }
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            int countChar = 0;
            txtMaHoa.Text = "";
            txtGiaiMa.Text = "";
            if (txtShift.Text == "" || txt_Input.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtShift.Text != "")
            {
                int countWrongShift = 0;
                for (int i = 0; i < txtShift.Text.Length; i++)
                {
                    if (txtShift.Text[i] < 48 || txtShift.Text[i] > 57)
                        countWrongShift++;
                }
                if (countWrongShift != 0)
                    MessageBox.Show("Số ký tự cần dịch không đúng. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    string decodedString = txt_Input.Text;
                    char[] upperChar = { 'Z', 'Y', 'X', 'W', 'V', 'U', 'T', 'S', 'R', 'Q', 'P', 'O', 'N', 'M', 'L', 'K', 'J', 'I', 'H', 'G', 'F', 'E', 'D', 'C', 'B', 'A' };
                    for (int i = 0; i < decodedString.Length; i++)
                    {
                        countChar = 0;
                        for (int j = 0; j < 26; j++)
                        {
                            if (decodedString[i].ToString().ToUpper() == upperChar[j].ToString())
                            {
                                countChar++;
                                if (char.IsLower(decodedString[i]) == true)
                                    txtGiaiMa.Text += upperChar[(j + int.Parse(txtShift.Text)) % 26].ToString().ToLower();
                                else
                                    txtGiaiMa.Text += upperChar[(j + int.Parse(txtShift.Text)) % 26];
                            }
                        }
                        if (countChar == 0)
                            txtGiaiMa.Text += decodedString[i];

                    }
                }
            }
        }
    }
}