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
        private void setStyle(Physics instance_physics)
        {
            // clear default graph series values
            Graph.Series["Series_Cannon"].Points.Clear();
            Graph.Series["Series_Curve"].Points.Clear();
            Graph.Series["Series_Target"].Points.Clear();
            // style of graph's series
            Graph.Series["Series_Cannon"].Color = Color.LightSkyBlue;
            Graph.Series["Series_Curve"].Color = Color.LightSkyBlue;
            Graph.Series["Series_Target"].Color = Color.Orange;
            Graph.Series["Series_Curve"].BorderWidth = 3;
            //Graph.Series["Series_Curve"].BorderDashStyle = ChartDashStyle.Dash;
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
            setStyle(instance_physics);
            // draw cannon
            Graph.Series["Series_Cannon"].Points.AddXY(0, 0);
            // draw target
            Graph.Series["Series_Target"].Points.AddXY(physics_component.target_distance, physics_component.target_height);

        }

        // draw Cannon Trajectory on graph
        public void drawCurve()
        {
            // calculate the increment
            double increment = Utilities.GRAPH_CURVE_INCREMENT;
            double y = 0; int index = 0; double x = 0;
            // calculate y position of bullet
            y = physics_component.bullet_trajectory_current_position_y(x);
            while ((y>=0)&&(index<Utilities.GRAPH_ELEMENTS_NUMBER))
            {
                // check if with this element the curve goes under zero
                if(y>=0)
                    // draw the point into the graph
                    Graph.Series["Series_Curve"].Points.AddXY(x, y);
                // add point to my double[] array
                curve_map_x[index] = x;
                curve_map_y[index] = y;
                // increment position for generate next step
                x += increment;
                // calculate y position of bullet
                y = physics_component.bullet_trajectory_current_position_y(x);
                // increment arrays' index
                index++;
            }
            // now i have the point which brak the while (assuming index < limit array's size)
            // re-calculate the value of last points accepted
            x -= increment;
            //x -= increment;
            // now i re-calculate the y value for this point
            y = physics_component.bullet_trajectory_current_position_y(x);
            // now check if i should finally design some points for adjust the curve
            // if in the previous while program exited because index reach array's max lenght limit
            // but y is still > 0 then i add some points to bullet's trajectory to complete the curve and reach zero
            // (i only draw them without adding to the array)
            if (y>=0)
            {
                increment = Utilities.GRAPH_CURVE_INCREMENT/10;
                while (y >= 0)
                {
                    // increment position for generate next step
                    x += increment;
                    // calculate y position of bullet
                    y = physics_component.bullet_trajectory_current_position_y(x);
                    // check if with this element the curve goes under zero
                    if (y >= 0)
                        // draw the point into the graph
                        Graph.Series["Series_Curve"].Points.AddXY(x, y);
                }
                   
                
            }
        }
    }
}
