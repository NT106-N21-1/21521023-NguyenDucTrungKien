using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.Devices;
using System.Net.Http;

namespace Lab3
{
    public partial class Bai3_Client : Form
    {
        public Bai3_Client()
        {
            InitializeComponent();
        }
        TcpClient tcpClient = new TcpClient();
        NetworkStream ns;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipep = new IPEndPoint(ipAddress, 8080);
            tcpClient.Connect(ipep);
            ns = tcpClient.GetStream();
            btnDisconnect.Enabled = true;
            btnConnect.Enabled = false;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if(btnConnect.Enabled == true)
            {
                MessageBox.Show("Vui lòng kết nối vào server!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string message = rtb_text.Text;
                Byte[] sendByte = Encoding.UTF8.GetBytes(message);
                ns.Write(sendByte, 0, sendByte.Length);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            ns.Close();
            tcpClient.Close();
            btnDisconnect.Enabled = false;
            btnConnect.Enabled = true;
        }
    }
}
