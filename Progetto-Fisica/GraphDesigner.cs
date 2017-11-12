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
        /********************************************************************
         * PROPERTIES
        ********************************************************************/
        Chart Graph;
        Physics physics_component;
        // parallels arrays for direct access to points
        public double[] curve_map_x = new double[Utilities.GRAPH_ELEMENTS_NUMBER];
        public double[] curve_map_y = new double[Utilities.GRAPH_ELEMENTS_NUMBER];

        /********************************************************************
        * METHODS
        ********************************************************************/
        // constructor
        public GraphDesigner(Physics instance_physics, Chart main_graph)
        {
            // save main graph instance
            this.Graph = main_graph;
            // save Physics class instance
            this.physics_component = instance_physics;
            // instance cannon, target and axis scale
            instanceGraphicsElements(physics_component);
            // instance point array
            for (int j = 0; j < Utilities.GRAPH_ELEMENTS_NUMBER; j++)
            {
                curve_map_x[j] = 0;
                curve_map_y[j] = 0;
            }
        }

        // update physics class instance
        public void updatePhysicsInstance(Physics instance_physics)
        {
            // save Physics class instance
            this.physics_component = instance_physics;
        }

        // set axis scale
        public void setAxisScale()
        {
            double scale_x = (int)Utilities.maxValue(curve_map_x) + 2;
            double scale_y = (int)Utilities.maxValue(curve_map_y) + 2;
            Graph.Series["Series_Set_Axis_Scale"].Points.Clear();
            Graph.Series["Series_Set_Axis_Scale"].Points.AddXY(scale_x, scale_y);
        }

        // set default style
        private void setStyle()
        {
            // clear default graph series values
            Graph.Series["Series_Cannon"].Points.Clear();
            Graph.Series["Series_Curve"].Points.Clear();
            Graph.Series["Series_Target"].Points.Clear();
            // style of graph's series
            Graph.Series["Series_Cannon"].Color = Color.LightSkyBlue;
            Graph.Series["Series_Curve"].Color = Color.LightSkyBlue;
            Graph.Series["Series_Target"].Color = Color.Orange;
            Graph.Series["Series_Curve"].BorderWidth = 2;
            Graph.Series["Series_Curve"].BorderDashStyle = ChartDashStyle.Dash;
            Graph.Series["Series_Set_Axis_Scale"].IsVisibleInLegend = false;
            // other settings
            Graph.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
        }

        // instance base graphics elements
        public void instanceGraphicsElements(Physics instance_physics)
        {
            // update physics instance
            updatePhysicsInstance(instance_physics);
            // set default style
            setStyle();
            // draw cannon
            Graph.Series["Series_Cannon"].Points.AddXY(0, 0);
            // draw target
            Graph.Series["Series_Target"].Points.AddXY(physics_component.target_distance, physics_component.target_distance);

        }

        // draw Cannon Trajectory on graph
        public void drawCurve()
        {
            // calculate the increment
            double increment = Utilities.GRAPH_CURVE_INCREMENT;
            double y = 0; double x = 0; int index = 0;
            while ((y>=0)&&(index<Utilities.GRAPH_ELEMENTS_NUMBER))
            {
                // calculate y position of bullet
                y = physics_component.bullet_trajectory_current_position_y(x);
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

            /*
             * TODO:
             * add plus points for draw line to reach zero value in y axis
             */
            if (index < Utilities.GRAPH_ELEMENTS_NUMBER)
            {

            }
        }
    }
}
