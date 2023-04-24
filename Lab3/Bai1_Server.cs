using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai1_Server : Form
    {
        public Bai1_Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void btnLis_Click(object sender, EventArgs e)
        {
            int count = 0;
            for(int i = 0; i<txtPort.Text.Length; i++)
            {
                if (txtPort.Text[i] < 48 || txtPort.Text[i] > 57)
                {
                    count++;
                }    
            }
            if(txtPort.Text == "")
            {
                MessageBox.Show("Vui lòng nhập cổng kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(count != 0)
            {
                MessageBox.Show("Cổng kết nối không hợp lệ. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
                thdUDPServer.Start();
                MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLis.Enabled = false;
                txtPort.ReadOnly = true;
            }
        }
        public void serverThread()
        {
            UdpClient client = new UdpClient(int.Parse(txtPort.Text));
            while(true) 
            {
                string IP_client;
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, int.Parse(txtPort.Text));
                Byte[] receiveData = client.Receive(ref endPoint);
                string returnData = Encoding.UTF8.GetString(receiveData);
                IP_client = endPoint.Address.ToString();
                richTextBox1.Text += IP_client + ": " + returnData + "\n";
            }
        }
    }
}
