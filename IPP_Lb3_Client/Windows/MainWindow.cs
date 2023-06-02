using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace IPP_Lb3.Windows
{
    public partial class MainWindow : Form
    {
        private const string ServerIp = "192.168.31.208";

        private static void StartDrawSin()
        {
            try
            {
                var client = new TcpClient(ServerIp, 1111);
                var stream = client.GetStream();
                SendRequest(stream, "1");
            }
            catch
            {
                MessageBox.Show("Server offile!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private static void StartDrawPar()
        {
            try
            {
                var client = new TcpClient(ServerIp, 1111);
                var stream = client.GetStream();
                SendRequest(stream, "2");
            }
            catch
            {
                MessageBox.Show("Server offile!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonDrawSin_Click(object sender, EventArgs e)
        {
            var threadStartDrawSin = new ThreadStart(StartDrawSin);
            var thread = new Thread(threadStartDrawSin);
            thread.Start();
        }

        private void buttonDrawPar_Click(object sender, EventArgs e)
        {
            var threadStartDrawPar = new ThreadStart(StartDrawPar);
            var thread = new Thread(threadStartDrawPar);
            thread.Start();
        }

        private static void SendRequest(Stream stream, string request) 
        {
            var requestBuffer = Encoding.ASCII.GetBytes(request);
            stream.Write(requestBuffer, 0, requestBuffer.Length);
        }
    }
}