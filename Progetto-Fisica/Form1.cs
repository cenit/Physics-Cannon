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
        /********************************************************************
        * PROPERTIES
        ********************************************************************/
        GraphDesigner graph_designer;
        // input variable
        double angle = 0;
        double time_flight = 0;
        double time_rise = 0;
        double time_fall = 0;
        double target_distance = 0;
        double target_height = 0;
        double speed = 0;
        double mass = 0;
        double max_height = 0;

        /********************************************************************
        * METHODS
        ********************************************************************/
        // main constructor
        public Form1()
        {
            InitializeComponent();
            Click += button1_Click;
            // show input default value
            writeInputComponent();
            // instance graph designer
            graph_designer = new GraphDesigner(Graph);
        }

        // read Input Value
        public void readInputComponent()
        {
            try
            {
                angle           =   Math.Round(Double.Parse(Input_Angle.Text), Utilities.number_round_decimal);
                mass            =   Math.Round(Double.Parse(Input_Mass.Text), Utilities.number_round_decimal);
                speed           =   Math.Round(Double.Parse(Input_Speed.Text), Utilities.number_round_decimal); ;
                target_distance =   Math.Round(Double.Parse(Input_Target_X.Text), Utilities.number_round_decimal);
                target_height   =   Math.Round(Double.Parse(Input_Target_Y.Text), Utilities.number_round_decimal);
                time_flight     =   Math.Round(Double.Parse(Input_Time.Text), Utilities.number_round_decimal);
                time_rise       =   Math.Round(Double.Parse(Input_Time_Rise.Text), Utilities.number_round_decimal);
                time_fall       =   Math.Round(Double.Parse(Input_Time_Fall.Text), Utilities.number_round_decimal);
            }
            catch (Exception ex)
            {
                Console.WriteLine("eccezione generata --> " + ex.Message);
            }

        }

        // write Input Value
        public void writeInputComponent()
        {
            try
            {
                Input_Angle.Text        =   Math.Round(angle, 3).ToString();
                Input_Mass.Text         =   Math.Round(mass, 3).ToString();
                Input_Speed.Text        =   Math.Round(speed, 3).ToString();
                Input_Target_X.Text     =   Math.Round(target_distance, 3).ToString();
                Input_Target_Y.Text     =   Math.Round(target_height, 3).ToString();
                Input_Time.Text         =   Math.Round(time_flight, 3).ToString();
                Input_Time_Rise.Text    =   Math.Round(time_rise, 3).ToString();
                Input_Time_Fall.Text    =   Math.Round(time_fall, 3).ToString();
                Output_Height.Text      =   Math.Round(max_height, 3).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("eccezione generata --> " + ex.Message);
            }

        }

        // calculate component
        public void calculateComponent(double angle, double time, double target_distance, double target_height, double speed, double mass, string missing_value)
        {
            max_height = Utilities.maxValue(graph_designer.curve_map_y);
            switch(missing_value)
            {
                case "time":
                {
                    // time rise
                    double vi_y = Utilities.calculateViY(speed, angle);
                    time_rise = vi_y / Utilities.g_power_acceleration;
                    // time fall   tfall = √(2·h/g)
                    double vi_x = Utilities.calculateViY(speed, angle);
                    time_fall = Math.Sqrt((2*max_height)/Utilities.g_power_acceleration);
                    // time flight
                    time_flight = time_rise + time_fall;
                    // update values
                    writeInputComponent();
                    break;
                }
                deafult:
                {
                    // update values
                    writeInputComponent();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // draw base graphics elements on chart
            graph_designer.instanceGraphicsElements();
            // read data from Input TextBox
            readInputComponent();
            // draw bullet trajectory
            graph_designer.drawCurve(angle, time_flight, target_distance, target_height, speed, mass);
            // calculate Component
            calculateComponent(angle, time_flight, target_distance, target_height, speed, mass, "time");
            // set axis scale
            graph_designer.setAxisScale((int)Utilities.maxValue(graph_designer.curve_map_x)+2, (int)Utilities.maxValue(graph_designer.curve_map_y)+2);
            // force Redraw the form
            this.Invalidate();
            Console.WriteLine(" ");
        }
    }

}
