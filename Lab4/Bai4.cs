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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private string GetHTML(string szURL)
        {
            WebRequest request = WebRequest.Create(szURL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }

        private void Download()
        {
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(txtURL.Text);
            myClient.DownloadFile(txtURL.Text, txtFileURL.Text);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri(txtURL.Text);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string response = GetHTML(txtURL.Text);

            ViewSource viewSource = new ViewSource(response);
            viewSource.Show();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Download();
        }
    }
}
