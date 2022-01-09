using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Robot_Control
{
    public partial class Gráfico : Form
    {
        public Gráfico()
        {
            InitializeComponent();
            grafic();
        }

        private void Gráfico_Load(object sender, EventArgs e)
        {

        }
        public void grafic()
        {
            int i, Max, Men;

            var chart = chart1.ChartAreas[0];
            Max = Program.Maior;
            Men = Program.Menor;
            chart1.Visible = true;
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = 21;

            chart.AxisY.Minimum = Men - 4;
            chart.AxisY.Maximum = Max + 4;
        
            if (Max < 100)
            {
                chart.AxisY.Interval = 1;
            }
            if (Max > 100 && Max <= 200)
            {
                chart.AxisY.Interval = 10;
            }
            if (Max > 200 && Max <= 300)
            {
                chart.AxisY.Interval = 20;
            }
            if (Max > 300)
            {
                chart.AxisY.Interval = 30;
            }
           

            chart.AxisX.Interval = 1;

            chart.AxisY.Minimum = Men - 4;
            chart.AxisY.Maximum = Max + 4;

            chart1.Series.Add("Medições");
            chart1.Series["Medições"].ChartType = SeriesChartType.Spline;
            chart1.Series["Medições"].Color = Color.Red;
            chart1.Series[0].IsVisibleInLegend = false;

            //chart1.Series["Medições"].Points.AddXY((0), 0;

            for (i = 0; i < 20; i++)
            {
                chart1.Series["Medições"].Points.AddXY((i+1), Program.Med[i]);
            }
        }

    }
}
