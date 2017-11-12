using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Fisica
{
    class Physics
    {
        /********************************************************************
        * PROPERTIES
        ********************************************************************/
        // input variable
        public double angle_degrees;
        public double time_flight;
        public double time_rise;
        public double time_fall;
        public double target_distance;
        public double target_height;
        public double speed;
        public double mass;
        public double max_height;
        public double vi_x;
        public double vi_y;
        public double angle_radiants;
        public double final_position;


        /********************************************************************
        * METHODS
        ********************************************************************/
        public Physics()
        {
            angle_degrees = 0;
            time_flight = 0;
            time_rise = 0;
            time_fall = 0;
            target_distance = 3;
            target_height = 3;
            speed = 0;
            mass = 0;
            max_height = 0;
            vi_x = 0;
            vi_y = 0;
            angle_radiants = 0;
            final_position = 0;
        }

        // function for calculate y position of bullet
        public double bullet_trajectory_current_position_y(double temporary_bullet_position_x)
        {
            double temporary_bullet_position_y = 0;
            angle_radiants = Utilities.ToRadians(angle_degrees);
            calculateViX();
            calculateViY();
            temporary_bullet_position_y = -1 * Utilities.g_power_acceleration / (2 * Math.Pow(vi_x, 2)) * Math.Pow(temporary_bullet_position_x, 2);
            temporary_bullet_position_y += (vi_y / vi_x) * temporary_bullet_position_x;
            Console.WriteLine("posizione proiettile -->  [" + temporary_bullet_position_x + ", " + temporary_bullet_position_y + "]");
            return temporary_bullet_position_y;
        }

        /*
         * TODO: check if bullet hit the target 
         */
        // function for calculate if bullet hit the target
        public bool bullet_trajectory_current_position_y(double temporary_bullet_position_x, bool match_target)
        {
            bool hit_target = false;
            // ...
            return hit_target;
        }

        // calculate vi_x
        public void calculateViX()
        {
            angle_radiants = Utilities.ToRadians(angle_degrees);
            vi_x = speed * Math.Cos(angle_radiants);
        }

        // calculate vi_y
        public void calculateViY()
        {
            angle_radiants = Utilities.ToRadians(angle_degrees);
            vi_y = speed * Math.Sin(angle_radiants);
        }

        // calculate vi_y
        public void calculateFinalPosition()
        {
            angle_radiants = Utilities.ToRadians(angle_degrees);
            vi_x = speed * Math.Cos(angle_radiants);
            final_position = vi_x * time_flight;
        }

        // function for calculate maximum height of bullet
        public void calculateMaxHeight()
        {
            angle_radiants = Utilities.ToRadians(angle_degrees);
            vi_y = speed * Math.Sin(angle_radiants);
            max_height = (vi_y * time_rise) - (0.5 * Utilities.g_power_acceleration * Math.Pow(time_rise, 2));
        }

        public void calculateTimeRise()
        {
            // time rise
            time_rise = vi_y / Utilities.g_power_acceleration;     
        }

        public void calculateTimeFall()
        {
            // time fall
            time_fall = Math.Sqrt((2 * max_height) / Utilities.g_power_acceleration);
        }

        public void calculateTimeFlight()
        {
            // time flight
            time_flight = time_rise + time_fall;
        }
    }
}
