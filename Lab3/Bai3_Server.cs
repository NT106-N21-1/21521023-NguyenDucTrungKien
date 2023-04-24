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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3
{
    public partial class Bai3_Server : Form
    {
        public Bai3_Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        TcpListener tcpListener;
        IPEndPoint ipepServer;
        List<NetworkStream> networkStreams = new List<NetworkStream>();

        private void btnListen_Click(object sender, EventArgs e)
        {
            ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            tcpListener = new TcpListener(ipepServer);
            tcpListener.Start();
            StartUnsafeThread();
            MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnListen.Enabled = false;
        }
        private void StartUnsafeThread()
        {
            Thread acceptConnection = new Thread(new ThreadStart(AcceptConnection));
            acceptConnection.Start();
        }

        private void ReceiveMessage(Socket client)
        {
            while (client.Connected)
            {
                byte[] recv = new byte[1024];
                client.Receive(recv);
                richTextBox1.Text += Encoding.UTF8.GetString(recv).Replace("\0", "") + "\n";
            }
        }
        private void AcceptConnection()
        {
            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                Socket client = tcpClient.Client;
                NetworkStream ns = tcpClient.GetStream();
                networkStreams.Add(ns);
                string[] clientInfo = { ((IPEndPoint)client.RemoteEndPoint).Address.ToString(), ((IPEndPoint)client.RemoteEndPoint).Port.ToString() };
                Thread acceptConnection = new Thread(() => ReceiveMessage(client));
                acceptConnection.Start();
            }
        }
    }
}
