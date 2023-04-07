using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Xmin = double.Parse(textBox1.Text);
            double Xmax = double.Parse(textBox2.Text);
            double Step = double.Parse(textBox3.Text);
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step);
            double[] x = new double[count];
            double[] y1 = new double[count];
            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + Step*i;
                y1[i] = 0.0025 * 2.3 * Math.Pow(x[i], 3) + Math.Sqrt(x[i] + Math.Pow(Math.E, 0.82));
            }
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            chart1.Series[0].Points.DataBindXY(x, y1);


        }
    }
}
