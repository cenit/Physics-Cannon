using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Progetto_Fisica
{
    class GraphDesigner
    {
        Chart Graph;
        Point[] curve_array_points = new Point[2*Utilities.GRAPH_ELEMENTS_NUMBER];
        double[] curve_map_x = new double[2 * Utilities.GRAPH_ELEMENTS_NUMBER];
        double[] curve_map_y = new double[2 * Utilities.GRAPH_ELEMENTS_NUMBER];
        public GraphDesigner(Chart main_graph)
        {
            // save main graph instance
            this.Graph=main_graph;
            // clear default graph series values
            Graph.Series["Series_Cannon"].Points.Clear();
            Graph.Series["Series_Curve"].Points.Clear();
            Graph.Series["Series_Target"].Points.Clear();
            // draw cannon
            Graph.Series["Series_Cannon"].Points.AddXY(0, 0);
            // draw target
            Graph.Series["Series_Target"].Points.AddXY(15, 15);
            // instance point array
            for (int j=0; j< 2*Utilities.GRAPH_ELEMENTS_NUMBER; j++)
            {
                curve_array_points[j] = new Point(0, 0);
                curve_map_x[j] = 0;
                curve_map_y[j] = 0;
            }
        }

        public void instanceGraphicsElements()
        {
            // clear default graph series values
            Graph.Series["Series_Cannon"].Points.Clear();
            Graph.Series["Series_Curve"].Points.Clear();
            Graph.Series["Series_Target"].Points.Clear();
            // draw cannon
            Graph.Series["Series_Cannon"].Points.AddXY(0, 0);
            // draw target
            Graph.Series["Series_Target"].Points.AddXY(15, 15);// clear default graph series values
            Graph.Series["Series_Cannon"].Points.Clear();
            Graph.Series["Series_Curve"].Points.Clear();
            Graph.Series["Series_Target"].Points.Clear();
            // draw cannon
            Graph.Series["Series_Cannon"].Points.AddXY(0, 0);
            // draw target
            Graph.Series["Series_Target"].Points.AddXY(15, 15);
        }

        public void drawCurve(int speed, int angle)
        {
            double y_value = 0; double x_value = 0; int cont = Utilities.GRAPH_ELEMENTS_NUMBER;
            for (int j = 0; j < 2*Utilities.GRAPH_ELEMENTS_NUMBER; j++)
            {
                x_value = j;
                if (j <= Utilities.GRAPH_ELEMENTS_NUMBER)
                {
                    y_value = Utilities.bullet_trajectory_y(speed, x_value, -angle);
                    Graph.Series["Series_Curve"].Points.AddXY(x_value, y_value);
                    curve_map_x[j]=x_value; curve_map_y[j] = y_value;
                    Console.WriteLine("{"+ j +"} ---> [" + x_value + ", " + y_value + "]");
                }
                if (j > Utilities.GRAPH_ELEMENTS_NUMBER)
                {
                    cont--;
                    y_value = curve_map_y[cont];
                    Graph.Series["Series_Curve"].Points.AddXY(x_value, y_value);
                    curve_map_x[j] = x_value; curve_map_y[j] = y_value;
                    Console.WriteLine("{" + j + "} ---> [" + j + ", " + curve_map_y[cont] + "]");
                }
            }
        }
    }
}
