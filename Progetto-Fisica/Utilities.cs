﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Progetto_Fisica
{
    class Utilities
    {
        // Propietries
        public static double air_friction_coefficient = (1.5 * 0.000005);
        public static double g_power_acceleration = 9.7803184;
        public static int GRAPH_ELEMENTS_NUMBER = 100;
        public static double GRAPH_AXIS_SCALE_X = 9;
        public static double GRAPH_AXIS_SCALE_Y = 9;
        // Method

        // function for convert angle from degrees to radians
        public static double ToRadians(double val)
        {
            return (Math.PI / 180) * val;
        }

        // function for calculate y position of bullet
        public static double bullet_trajectory_y(double initial_speed, double bullet_position_x, double angle_degrees)
        {
            double bullet_position_y = 0;
            double angle_radiants = ToRadians(angle_degrees);
            double vi_x = initial_speed * Math.Cos(angle_radiants); 
            double vi_y = initial_speed * Math.Sin(angle_radiants);
            bullet_position_y = -1*g_power_acceleration/(2*Math.Pow(vi_x,2)) * Math.Pow(bullet_position_x,2);
            bullet_position_y += (vi_y / vi_x) *bullet_position_x;
            Console.WriteLine("posizione proiettile -->  [" + bullet_position_x + ", " + bullet_position_y + "]");
            return bullet_position_y;
        }

        // function for calculate if bullet hit the target
        public static bool bullet_trajectory_y(double initial_speed, double bullet_position_x, double target_position_y, double target_position_x, double bullet_position_y, double angle_degrees)
        {
            bool hit_target = false;
            double angle_radiants = ToRadians(angle_degrees);
            double vi_x = initial_speed * Math.Cos(angle_radiants);
            double vi_y = initial_speed * Math.Sin(angle_radiants);
            bullet_position_y = (g_power_acceleration * Math.Pow(bullet_position_x, 2)) / (2 * Math.Pow(vi_x, 2));
            bullet_position_y += (vi_y * bullet_position_x) / vi_x;
            return hit_target;
        }

        // function for calculate maximum height of bullet
        public static double bullet_max_height(double initial_speed, double time, double angle_degrees)
        {
            // h = yo + vyo·t - 0.5·g·t2
            double h = 0;
            double angle_radiants = ToRadians(angle_degrees);
            double vi_y = initial_speed * Math.Sin(angle_radiants);
            h = (vi_y * time) - (0.5*g_power_acceleration*Math.Pow(time, 2));
            return h;
        }
    }
}
