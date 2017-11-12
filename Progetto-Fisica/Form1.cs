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
        Physics physics_component;

        /********************************************************************
        * METHODS
        ********************************************************************/
        // main constructor
        public Form1()
        {
            InitializeComponent();
            Click += button1_Click;
            // instance Physics class
            physics_component = new Physics();
            // show input default value
            writeInputComponent();
            // instance graph designer
            graph_designer = new GraphDesigner(physics_component, Graph);
        }

        // read Input Value
        public void readInputComponent()
        {
            try
            {
                physics_component.angle_degrees   =   Math.Round(Double.Parse(Input_Angle.Text), Utilities.number_round_decimal);
                physics_component.mass            =   Math.Round(Double.Parse(Input_Mass.Text), Utilities.number_round_decimal);
                physics_component.speed           =   Math.Round(Double.Parse(Input_Speed.Text), Utilities.number_round_decimal); ;
                physics_component.target_distance =   Math.Round(Double.Parse(Input_Target_X.Text), Utilities.number_round_decimal);
                physics_component.target_height   =   Math.Round(Double.Parse(Input_Target_Y.Text), Utilities.number_round_decimal);
                physics_component.time_flight     =   Math.Round(Double.Parse(Input_Time.Text), Utilities.number_round_decimal);
                physics_component.time_rise       =   Math.Round(Double.Parse(Input_Time_Rise.Text), Utilities.number_round_decimal);
                physics_component.time_fall       =   Math.Round(Double.Parse(Input_Time_Fall.Text), Utilities.number_round_decimal);
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
                Input_Angle.Text        =   Math.Round(physics_component.angle_degrees, Utilities.number_round_decimal).ToString();
                Input_Mass.Text         =   Math.Round(physics_component.mass, Utilities.number_round_decimal).ToString();
                Input_Speed.Text        =   Math.Round(physics_component.speed, Utilities.number_round_decimal).ToString();
                Input_Target_X.Text     =   Math.Round(physics_component.target_distance, Utilities.number_round_decimal).ToString();
                Input_Target_Y.Text     =   Math.Round(physics_component.target_height, Utilities.number_round_decimal).ToString();
                Input_Time.Text         =   Math.Round(physics_component.time_flight, Utilities.number_round_decimal).ToString();
                Input_Time_Rise.Text    =   Math.Round(physics_component.time_rise, Utilities.number_round_decimal).ToString();
                Input_Time_Fall.Text    =   Math.Round(physics_component.time_fall, Utilities.number_round_decimal).ToString();
                Output_Height.Text      =   Math.Round(physics_component.max_height, Utilities.number_round_decimal).ToString();
                Output_Distance.Text    =   Math.Round(physics_component.final_position, Utilities.number_round_decimal).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("eccezione generata --> " + ex.Message);
            }

        }

        // calculate component
        public void calculateComponent(string missing_value)
        {
            physics_component.calculateViX();
            physics_component.calculateViY();
            switch (missing_value)
            {
                case "time":
                {
                    // time rise
                    physics_component.calculateTimeRise();
                    // max height
                    physics_component.calculateMaxHeight();
                    // time fall
                    physics_component.calculateTimeFall();
                    break;
                }
                case "height":
                {
                    //physics_component.calculateTime();
                    break;
                }
                deafult:
                {
                    // ...
                }
            }
            // time flight
            physics_component.calculateTimeFlight();
            // distance covered
            physics_component.calculateFinalPosition();
            // update values
            writeInputComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // read data from Input TextBox
            readInputComponent();
            // draw base graphics elements on chart
            graph_designer.instanceGraphicsElements(physics_component);
            // draw bullet trajectory
            graph_designer.drawCurve();
            // calculate Component
            calculateComponent("time");
            // set axis scale
            graph_designer.setAxisScale();
            // force Redraw the form
            this.Invalidate();
            //Console.WriteLine(" ");
        }
    }

}
