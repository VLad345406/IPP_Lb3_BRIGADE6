using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IPP_Lb3_Server.Windows
{
    public partial class ServerWindow : Form
    {
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
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            DrawSin();
        }

        private void buttonPar_Click(object sender, EventArgs e)
        {
            DrawPar();
        }
    }
}