using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        private void Download()
        {
            WebClient MyClient = new WebClient();
            Stream response = MyClient.OpenRead(txtURL.Text);
            MyClient.DownloadFile(txtURL.Text, txtFileURL.Text);
        }
        private string getHTML(string URL)
        {
            WebRequest MyRequest = WebRequest.Create(URL);
            WebResponse response = MyRequest.GetResponse();
            Stream data = response.GetResponseStream();
            StreamReader sr = new StreamReader(data);
            string str = sr.ReadToEnd();
            response.Close();
            return str;
        }
        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            Download();
            string html = getHTML(txtURL.Text);
            rtbShow.Text = html;
        }
    }
}
