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
    public partial class Bai1_Client : Form
    {
        public Bai1_Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int count = 0;
            IPAddress ip;
            for (int i = 0; i < txt_Port.Text.Length; i++)
            {
                if (txt_Port.Text[i] < 48 || txt_Port.Text[i] > 57)
                {
                    count++;
                }
            }
            if (txt_IP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ IP.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!IPAddress.TryParse((txt_IP.Text), out ip))
            {
                MessageBox.Show("Hãy nhập chính xác IP của người nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Port.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số cổng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(count != 0)
            {
                MessageBox.Show("Số cổng không hợp lệ. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(rtbMess.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tin nhắn để gửi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
            else
            {
                string message = rtbMess.Text;
                UdpClient udpClient = new UdpClient();
                Byte[] sendBytes = Encoding.UTF8.GetBytes(message);
                udpClient.Send(sendBytes, sendBytes.Length, txt_IP.Text, int.Parse(txt_Port.Text));
                rtbMess.Text = "";
            }
        }
    }
}
