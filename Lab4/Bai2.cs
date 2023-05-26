using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private string GettHTML(string szURL)
        {
            WebRequest request = WebRequest.Create(szURL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromURL = reader.ReadToEnd();
            response.Close();
            return responseFromURL;
        }
        private async void btnPost_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string html = GettHTML(txtURL.Text);
            richTextBox1.Text = html;
            //StringContent jsonContent = new (JsonSerializer.Serialize(txtData.Text), Encoding.UTF8, "application/json");
            //HttpResponseMessage httpResponseMessage = await client.PostAsync(txtData.Text, jsonContent);
            //var jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            //Console.WriteLine($"{jsonResponse}\n");
        }
    }
}
