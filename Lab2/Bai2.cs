using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                FileStream fs = new FileStream(filePath, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                FileInfo fileInfo = new FileInfo(filePath);
                long fileLength = fileInfo.Length;
                string fileName = ofd.SafeFileName.ToString();
                string file_URL = fs.Name.ToString();
                rtbShow.Text = sr.ReadToEnd();
                int lineCount = 0;
                int wordCount = 0;
                int charCount = 0;
                for (int i = 0; i < rtbShow.Text.Length; i++)
                {
                    charCount++;
                    if (rtbShow.Text[i] == ' ' || rtbShow.Text[i] == '\n')
                    {
                        wordCount++;
                    }
                    if (rtbShow.Text[i] == '\n')
                    {
                        lineCount++;
                    }
                }
                wordCount += 1;
                lineCount += 1;
                txtFileName.Text = fileName;
                txtSize.Text = fileLength.ToString() + " bytes";
                txtURL.Text = file_URL;
                txtLineCount.Text = lineCount.ToString();
                txtWordCount.Text = wordCount.ToString();
                txtCharCount.Text = charCount.ToString();
                fs.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
