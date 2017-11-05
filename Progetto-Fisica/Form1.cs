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
        GraphDesigner graph_designer;
        public Form1()
        {
            InitializeComponent();
            Click += button1_Click;
            // instance graph designer
            graph_designer = new GraphDesigner(Graph);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graph_designer.instanceGraphicsElements();
            graph_designer.drawCurve(10, Int32.Parse(Input_Angle.Text));
            // force Redraw the form
            this.Invalidate(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawBezier(Pens.Black, pt1, pt2, pt3, pt4);
           
        }
    }
            
}
