using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03_BAI04
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        TcpClient tcpClient= new TcpClient();
        NetworkStream ns;

        void Connect()
        {

            IPAddress iPAdd1 = IPAddress.Parse("127.0.0.1");
            IPEndPoint iPEnd1 = new IPEndPoint(iPAdd1, 8080);

            IPAddress iPAdd2 = IPAddress.Parse("127.0.0.2");
            IPEndPoint iPEnd2 = new IPEndPoint(iPAdd2, 8080);
            try
            {
                tcpClient.Connect(iPEnd1);
                MessageBox.Show("Connected to Server 127.0.0.1");
                ns = tcpClient.GetStream();
            }
            catch (Exception ex)
            {
                tcpClient.Connect(iPEnd2);
                MessageBox.Show("Couldn't connect to server 127.0.0.1 \n Connected to Server 127.0.0.2");
                ns = tcpClient.GetStream();
            }
        
           
           

        }


        private void ConnectBT_Click(object sender, EventArgs e)
        {
            ConnectBT.Enabled = false;
            SendBT.Enabled = true;
            DisconnectBT.Enabled = true;
            Connect();

        }


        void Send()
        {
            string message = messageTB.Text;
            Byte[] sendByte= Encoding.UTF8.GetBytes(message);
            ns.Write(sendByte,0,sendByte.Length);
        }

        private void SendBT_Click(object sender, EventArgs e)
        {
            Send();
        }


        void Close_Stream()
        {
            tcpClient.Close();
            ns.Close();
            DisconnectBT.Enabled = false;
            SendBT.Enabled= false;
            ConnectBT.Enabled = true;
        }

      
       
        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            Close_Stream();
            this.Close();
        }

       
        private void DisconnectBT_Click(object sender, EventArgs e)
        {
            Close_Stream();
        }
    }
}
