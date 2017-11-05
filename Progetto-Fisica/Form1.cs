using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_Fisica
{
    public partial class Form1 : Form
    {
        Point[] curve_array_points = new Point[100];
        double[] array = new double[100];

        public Form1()
        {
            InitializeComponent();
            Click += button1_Click;

            chart1.Series["Series_Cannon"].Points.Clear();
            chart1.Series["Series_Curve"].Points.Clear();
            chart1.Series["Series_Target"].Points.Clear();
            chart1.Series["Series_Cannon"].Points.AddXY(0, 0);
            chart1.Series["Series_Target"].Points.AddXY(15, 15);
        }

        Point pt1 = new Point(0, 0), pt2 = new Point(0, 0), pt3 = new Point(0, 0), pt4 = new Point(0, 0),
              pt5 = new Point(0, 0), pt6 = new Point(0, 0), pt7 = new Point(0, 0), pt8 = new Point(0, 0);
        private void button1_Click(object sender, EventArgs e)
        {
            pt1 = new Point(0, 0); pt2 = new Point(5, 5); pt3 = new Point(10, 10);
            pt4 = new Point(15, 15); pt5 = new Point(20, 10); pt6 = new Point(25, 5); pt7 = new Point(30, 0);
            chart1.Series["Series_Curve"].Points.AddXY(pt1.X, pt1.Y);
            chart1.Series["Series_Curve"].Points.AddXY(pt2.X, pt2.Y);
            chart1.Series["Series_Curve"].Points.AddXY(pt3.X, pt3.Y);
            chart1.Series["Series_Curve"].Points.AddXY(pt4.X, pt4.Y);
            chart1.Series["Series_Curve"].Points.AddXY(pt5.X, pt5.Y);
            chart1.Series["Series_Curve"].Points.AddXY(pt6.X, pt6.Y);
            chart1.Series["Series_Curve"].Points.AddXY(pt7.X, pt7.Y);
            // force Redraw the form
            this.Invalidate(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawBezier(Pens.Black, pt1, pt2, pt3, pt4);
           
        }
    }
            
}
