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
        // parallels arrays for direct access to points
        double[] curve_map_x = new double[Utilities.GRAPH_ELEMENTS_NUMBER];
        double[] curve_map_y = new double[Utilities.GRAPH_ELEMENTS_NUMBER];

        // set axis scale
        public void setAxisScale(double scale_x, double scale_y)
        {
            Graph.Series["Series_Set_Axis_Scale"].Points.AddXY(scale_x, scale_y);
        }

        // instance base graphics elements
        public void instanceGraphicsElements()
        {
            // clear default graph series values
            Graph.Series["Series_Cannon"].Points.Clear();
            Graph.Series["Series_Curve"].Points.Clear();
            Graph.Series["Series_Target"].Points.Clear();
            // draw cannon
            Graph.Series["Series_Cannon"].Points.AddXY(0, 0);
            // draw target
            Graph.Series["Series_Target"].Points.AddXY(3, 3);
            // set axis scale
            setAxisScale(Utilities.GRAPH_AXIS_SCALE_X, Utilities.GRAPH_AXIS_SCALE_Y);
            // style of graph's series
            Graph.Series["Series_Cannon"].Color = Color.LightSkyBlue;
            Graph.Series["Series_Curve"].Color = Color.LightSkyBlue;
            Graph.Series["Series_Target"].Color = Color.Orange;
            Graph.Series["Series_Curve"].BorderWidth=2;
            Graph.Series["Series_Curve"].BorderDashStyle = ChartDashStyle.Dash;
            
            Graph.Series["Series_Set_Axis_Scale"].IsVisibleInLegend = false;
            // other settings
            Graph.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
        }

        // constructor
        public GraphDesigner(Chart main_graph)
        {
            // save main graph instance
            this.Graph=main_graph;
            // instance cannon, target and axis scale
            instanceGraphicsElements();
            // instance point array
            for (int j=0; j< Utilities.GRAPH_ELEMENTS_NUMBER; j++)
            {
                curve_map_x[j] = 0;
                curve_map_y[j] = 0;
            }
        }

        // draw Cannon Trajectory on graph
        public void drawCurve(int speed, int angle)
        {
            // calculate the increment
            double increment = 0.1;
            double y = 0; double x = 0; int index = 0;
            while ((y>=0)&&(index<Utilities.GRAPH_ELEMENTS_NUMBER))
            {
                // calculate y position of bullet 
                y = Utilities.bullet_trajectory_y(speed, x, angle);
                if(y>=0)
                    // draw the point into the graph
                    Graph.Series["Series_Curve"].Points.AddXY(x, y);
                // add point to my double[] array
                curve_map_x[index] = x;
                curve_map_y[index] = y;
                // next step for position
                x += increment;
                // increment arrays' index
                index++;
            }

            // add plus points for draw line to reach zero value in y axis
            if(index < Utilities.GRAPH_ELEMENTS_NUMBER)
            {

            }
        }
    }
}
