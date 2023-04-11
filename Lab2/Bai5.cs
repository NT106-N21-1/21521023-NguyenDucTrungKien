using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void btnNen_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Chọn thư mục để lưu:";
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                File.WriteAllText(sfd.FileName + ".txt", rtbShow.Text);
                using FileStream originateFileStream = File.Open(sfd.FileName + ".txt", FileMode.Open);
                using FileStream compressedFileStream = File.Create(sfd.FileName + ".gz");
                using var compressor = new GZipStream(compressedFileStream, CompressionMode.Compress);
                originateFileStream.CopyTo(compressor);
            }
        }

        private void btnGiaiNen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileToDecompressed = new FileInfo(ofd.FileName);
                using (FileStream originalFileStream = fileToDecompressed.OpenRead())
                {
                    string currentFileName = ofd.FileName;
                    string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompressed.Extension.Length);

                    using (FileStream decompressedFileStream = File.Create(newFileName + ".txt"))
                    {
                        using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                        {
                            decompressionStream.CopyTo(decompressedFileStream);
                        }
                    }
                }
            }
        }
    }
}
