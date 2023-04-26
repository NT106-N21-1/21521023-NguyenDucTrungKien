using System.Net;
using System.Net.Sockets;
using System.Text;

namespace LAB03_BAI04
{
    public partial class Sever : Form
    {
        public Sever()
        {
            InitializeComponent();
        }
        IPEndPoint ipEnd;
        Socket client;
        TcpListener listener;
        List<NetworkStream> networkStreams = new List<NetworkStream>();


        void Connect()
        {

            try
            {
                IPAddress ipADD = IPAddress.Parse("127.0.0.1");
                ipEnd = new IPEndPoint(ipADD, 8080);
                listener = new TcpListener(ipEnd);
                listener.Start();
                StartUnsafeThread();
                
                MessageBox.Show("Server starting on 127.0.0.1 ");
            }
            catch (Exception ex)
            {
                
                IPAddress ipADD = IPAddress.Parse("127.0.0.2");
                ipEnd = new IPEndPoint(ipADD, 8080);
                listener = new TcpListener(ipEnd);
                listener.Start();
                StartUnsafeThread();
                
                MessageBox.Show("Couldn't connect to server 127.0.0.1 \nServer starting on 127.0.0.2 ");
            }
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
                TcpClient tcpClient = listener.AcceptTcpClient();
                Socket client = tcpClient.Client;
                NetworkStream ns = tcpClient.GetStream();
                networkStreams.Add(ns);
                string[] clientInfo = { ((IPEndPoint)client.RemoteEndPoint).Address.ToString(), ((IPEndPoint)client.RemoteEndPoint).Port.ToString() };
                Thread acceptConnection = new Thread(() => ReceiveMessage(client));
                acceptConnection.Start();
            }
        }

        private void listenBT_Click(object sender, EventArgs e)
        {
            
            Connect();
            listenBT.Enabled = false;
        }

       
    }
}