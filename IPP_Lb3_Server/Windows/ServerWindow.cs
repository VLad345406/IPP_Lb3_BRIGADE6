using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPP_Lb3_Server.Windows
{
    public partial class ServerWindow : Form
    {
        private async Task StartServer()
        {
            //var listener = new TcpListener(IPAddress.Parse("192.168.31.208"), 1111);
            var listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 1111);
            listener.Start();

            while (true) {
                TcpClient client = await listener.AcceptTcpClientAsync();

                _ = HandleClientAsync(client);
            }
        }
        
        private async Task HandleClientAsync(TcpClient client) {
            var stream = client.GetStream();

            // Receive the request from the client
            var request = await FunctionReceive(stream);

            switch (request)
            {
                case "1":
                {
                    DrawSin();
                    break;
                }
                case "2":
                {
                    DrawPar();
                    break;
                }
            }
            client.Close();
        }
        
        private static async Task<string> FunctionReceive(NetworkStream stream)
        {
            var resultBuffer = new byte[1024];
            var resultBytesRead = await stream.ReadAsync(resultBuffer, 0, resultBuffer.Length);
            return Encoding.ASCII.GetString(resultBuffer, 0, resultBytesRead);
        }
        
        private void DrawSin()
        {
            const double a = -10;
            const double b = 10;
            const double h = 0.1;
            var x = a;

            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Minimum = -10;
            chart1.ChartAreas[0].AxisX.Maximum = 10;
            chart1.ChartAreas[0].AxisY.Minimum = -1.5;
            chart1.ChartAreas[0].AxisY.Maximum = 1.5;
            
            while (x <= b)
            {
                var y = Math.Sin(x);
                chart1.Series[0].Points.AddXY(x, y);
                x += h;
            }
        }

        private void DrawPar()
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Minimum = -5;
            chart1.ChartAreas[0].AxisX.Maximum = 5;
            chart1.ChartAreas[0].AxisY.Minimum = -5;
            chart1.ChartAreas[0].AxisY.Maximum = 2;

            for (double x = -10; x <= 10; x += 0.1)
            {
                var y = -x * x;
                chart1.Series[0].Points.AddXY(x, y);
            }
        }
        
        public ServerWindow()
        {
            InitializeComponent();
        }

        private void ServerWindow_Load(object sender, EventArgs e)
        {
            chart1.Series[0].BorderWidth = 3;
            StartServer();
        }
    }
}