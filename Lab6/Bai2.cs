using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            txtMaHoa.Text = "";
            txtGiaiMa.Text = "";
            int countChar = 0;
            int countX = 0;
            int countY = 0;
            if (txtKey.Text == "" || txt_Input.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtKey.Text != "")
            {
                int countWrongShift = 0;
                for (int i = 0; i < txtKey.Text.Length; i++)
                {
                    if (txtKey.Text[i] > 48 && txtKey.Text[i] < 57)
                        countWrongShift++;
                }
                if (countWrongShift != 0 || txtKey.Text.Length > txt_Input.Text.Length)
                    MessageBox.Show("Từ khóa bạn nhập không hợp lệ. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    string key = txtKey.Text;
                    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    char[,] vigenereMatrix = new char[26, 26];
                    for (int i = 0; i < 26; i++)
                    {
                        for (int j = 0; j < 26; j++)
                        {
                            vigenereMatrix[i, j] = alphabet[(j + i) % 26];
                        }
                    }
                    if(txtKey.Text.Length < txt_Input.Text.Length)
                    {
                        for(int i = 0; i < txt_Input.Text.Length - txtKey.Text.Length; i++)
                        {
                            key += txtKey.Text[i%txtKey.Text.Length];
                        }    
                    }    
                    for(int i = 0; i < txt_Input.Text.Length; i++)
                    {
                        countChar = 0;
                        for(int j = 0; j < 26; j++)
                        {
                            if (txt_Input.Text[i].ToString().ToUpper() == alphabet[j].ToString())
                            {
                                countChar++;
                                countX = j;
                            }
                            if (key[i].ToString().ToUpper() == alphabet[j].ToString())
                                countY = j;
                        }
                        if (countChar == 0)
                            txtMaHoa.Text += txt_Input.Text[i];    
                        else if (char.IsLower(txt_Input.Text[i]) == true)
                            txtMaHoa.Text += vigenereMatrix[countX, countY].ToString().ToLower();
                        else
                            txtMaHoa.Text += vigenereMatrix[countX, countY];
                    }    

                }
            }

        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            txtMaHoa.Text = "";
            txtGiaiMa.Text = "";
            int countChar = 0;
            int countX = 0;
            int countY = 0;
            if (txtKey.Text == "" || txt_Input.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtKey.Text != "")
            {
                int countWrongShift = 0;
                for (int i = 0; i < txtKey.Text.Length; i++)
                {
                    if (txtKey.Text[i] > 48 && txtKey.Text[i] < 57)
                        countWrongShift++;
                }
                if (countWrongShift != 0 || txtKey.Text.Length > txt_Input.Text.Length)
                    MessageBox.Show("Từ khóa bạn nhập không hợp lệ. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    string key = txtKey.Text;
                    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    char[,] vigenereMatrix = new char[26, 26];
                    for (int i = 0; i < 26; i++)
                    {
                        for (int j = 0; j < 26; j++)
                        {
                            vigenereMatrix[i, j] = alphabet[(j + i) % 26];
                        }
                    }
                    if (txtKey.Text.Length < txt_Input.Text.Length)
                    {
                        for (int i = 0; i < txt_Input.Text.Length - txtKey.Text.Length; i++)
                        {
                            key += txtKey.Text[i % txtKey.Text.Length];
                        }
                    }
                    for (int i = 0; i < txt_Input.Text.Length; i++)
                    {
                        countChar = 0;
                        for (int j = 0; j < 26; j++)
                        {
                            if (txt_Input.Text[i].ToString().ToUpper() == alphabet[j].ToString())
                            {
                                countChar++;
                            }
                            if (key[i].ToString().ToUpper() == alphabet[j].ToString())
                            {
                                countY = j;
                            }
                        }
                        for(int x = 0; x < 26; x++)
                        {
                            if (txt_Input.Text[i].ToString().ToUpper() == vigenereMatrix[x, countY].ToString())
                                countX = x;
                        }
                        if (countChar == 0)
                            txtGiaiMa.Text += txt_Input.Text[i];
                        else if (char.IsLower(txt_Input.Text[i]) == true)
                            txtGiaiMa.Text += alphabet[countX].ToString().ToLower();
                        else
                            txtGiaiMa.Text += alphabet[countX];
                    }
                }
            }
        }
    }
}
