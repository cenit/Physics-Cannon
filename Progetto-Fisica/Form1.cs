﻿using System;
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
                physics_component.angle_degrees   =     Math.Round(Double.Parse(Input_Angle.Text), Utilities.number_round_decimal);
                physics_component.mass            =     Math.Round(Double.Parse(Input_Mass.Text), Utilities.number_round_decimal);
                if (physics_component.mass <= 0)
                    physics_component.mass = 1;
                physics_component.speed           =     Math.Round(Double.Parse(Input_Speed.Text), Utilities.number_round_decimal); ;
                physics_component.target_distance =     Math.Round(Double.Parse(Input_Target_X.Text), Utilities.number_round_decimal);
                physics_component.target_height   =     Math.Round(Double.Parse(Input_Target_Y.Text), Utilities.number_round_decimal);
                physics_component.time_flight     =     Math.Round(Double.Parse(Input_Time.Text), Utilities.number_round_decimal);
                physics_component.time_rise       =     Math.Round(Double.Parse(Input_Target_Diameter.Text), Utilities.number_round_decimal);
                physics_component.time_fall       =     Math.Round(Double.Parse(Input_Target_Diameter.Text), Utilities.number_round_decimal);
                physics_component.bullet_diameter =     Math.Round(Double.Parse(Input_Bullet_Diameter.Text), Utilities.number_round_decimal);
                physics_component.target_diameter =     Math.Round(Double.Parse(Input_Target_Diameter.Text), Utilities.number_round_decimal);
                physics_component.air_speed       =     Double.Parse(Input_Air_Speed.Text);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("eccezione 1 generata --> " + ex.Message);
            }

        }

        // write Output Value
        public void writeInputComponent()
        {
            try
            {
                Input_Angle.Text                =   Math.Round(physics_component.angle_degrees, Utilities.number_round_decimal).ToString();
                Input_Mass.Text                 =   Math.Round(physics_component.mass, Utilities.number_round_decimal).ToString();
                Input_Speed.Text                =   Math.Round(physics_component.speed, Utilities.number_round_decimal).ToString();
                Input_Target_X.Text             =   Math.Round(physics_component.target_distance, Utilities.number_round_decimal).ToString();
                Input_Target_Y.Text             =   Math.Round(physics_component.target_height, Utilities.number_round_decimal).ToString();
                Input_Time.Text                 =   Math.Round(physics_component.time_flight, Utilities.number_round_decimal).ToString();
                Input_Target_Diameter.Text      =   Math.Round(physics_component.target_diameter, Utilities.number_round_decimal).ToString();
                Input_Bullet_Diameter.Text      =   Math.Round(physics_component.bullet_diameter, Utilities.number_round_decimal).ToString();
                Output_Height.Text              =   Math.Round(physics_component.max_height, Utilities.number_round_decimal).ToString();
                Output_Distance.Text            =   Math.Round(physics_component.final_position, Utilities.number_round_decimal).ToString();
                Output_Energy.Text              =   Math.Round(physics_component.energy, Utilities.number_round_decimal).ToString();
                Input_Air_Speed.Text            =   physics_component.air_speed.ToString();

                // bullet hit the target ?
                if (physics_component.target_hit)
                    Output_Target_Hit.Text = "SI";
                else
                    Output_Target_Hit.Text = "NO";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eccezione 2 generata --> " + ex.Message);
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
            }
            // time flight
            physics_component.calculateTimeFlight();
            // distance covered
            physics_component.calculateFinalPosition();
            // work with bullet and target position
            //if ((physics_component.target_distance == physics_component.target_start_position_x) && (physics_component.target_height == physics_component.target_start_position_y))
                // no input target position inserted --> shown on console an example of target's position hitted
                //physics_component.randomPositionForHitTarget();
           // else
                // bullet hit the target ?
                physics_component.hit_target();
            // energy
            physics_component.calculateEnergy();
            // update values
            writeInputComponent();
        }

        public void launch_simulation()
        {
            // read data from Input TextBox
            readInputComponent();
            // calculate Component
            calculateComponent("time");
            // set axis scale
            graph_designer.setAxisScale();
            // draw base graphics elements on chart
            graph_designer.instanceGraphicsElements(physics_component);
            // draw bullet trajectory
            graph_designer.drawCurve();
            // force Redraw the form
            this.Invalidate();
            //Console.WriteLine(" ");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            launch_simulation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            physics_component.randomPositionForHitTarget();
            writeInputComponent();
            launch_simulation();
        }

        /*private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                launch_simulation();
                Console.WriteLine("Enter key pressed");
            }

        }*/
    }

}
