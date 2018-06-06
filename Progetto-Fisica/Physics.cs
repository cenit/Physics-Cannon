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
        public double bullet_diameter;
        public double target_diameter;
        public double energy;
        //public double air_friction;
        public bool   target_hit;
        public double air_speed;

        public double target_start_position_x = 0;
        public double target_start_position_y = 10;

        /********************************************************************
        * METHODS
        ********************************************************************/
        public Physics()
        {
            angle_degrees = 30;
            time_flight = 0;
            time_rise = 0;
            time_fall = 0;
            target_distance = target_start_position_x;
            target_height = target_start_position_y;
            speed = 30;
            mass = 10;
            max_height = 0;
            vi_x = 0;
            vi_y = 0;
            angle_radiants = 0;
            final_position = 0;
            bullet_diameter = 2;
            target_diameter = 4;
            target_hit = false;
            energy = 0;
            air_speed = 0;
        }

        // function for calculate y position of bullet
        public double bullet_trajectory_current_position_y(double temporary_bullet_position_x)
        {
            // 4,8902
            double temporary_bullet_position_y = 0;
            angle_radiants = Utilities.ToRadians(angle_degrees);
            calculateViX();
            calculateViY();
            temporary_bullet_position_y = -1 * (Utilities.g_power_acceleration/2) / (Math.Pow(vi_x, 2)) * Math.Pow(temporary_bullet_position_x, 2);
            temporary_bullet_position_y += (vi_y / vi_x) * temporary_bullet_position_x;
            //Console.WriteLine("posizione proiettile -->  [" + temporary_bullet_position_x + ", " + temporary_bullet_position_y + "]");
            return temporary_bullet_position_y;
        }

        // function for calculate if bullet hit the target
        public void hit_target()
        {
            target_hit = false;
            int number_of_decimal_digits = Utilities.number_round_decimal;
            // count the decimal digits of target input position
            if (Utilities.countDecimalDigits(target_height) > Utilities.countDecimalDigits(target_distance))
                number_of_decimal_digits = Utilities.countDecimalDigits(target_height);
            else
                number_of_decimal_digits = Utilities.countDecimalDigits(target_distance);
            // check number of decimal digits for approximation (min = 2)
            if (number_of_decimal_digits < 2)
                number_of_decimal_digits = 2;
            // calculate bullet's y positon based on target's x position
            double y_bullet = bullet_trajectory_current_position_y(Math.Round(target_distance, number_of_decimal_digits));
            // if this y is equal to real target's y position then bullet will hit the target
            double target_max_y = Math.Round(target_height, number_of_decimal_digits) + (target_diameter/2);
            double target_min_y = Math.Round(target_height, number_of_decimal_digits) - (target_diameter/2);
            double bullet_top_y = Math.Round(y_bullet, number_of_decimal_digits) + (bullet_diameter/2);
            double bullet_bottom_y = Math.Round(y_bullet, number_of_decimal_digits) - (bullet_diameter/2);
            // check if bullet (which is under the target) hit target
            // Console.WriteLine(" --------------------------------------------------------------------- ");
            // Console.WriteLine("(proiettile) --- INF ==> " + bullet_bottom_y + "  ---  SUP ==> " + bullet_top_y + " --- ");
            // Console.WriteLine("(bersaglio)  --- INF ==> " + target_min_y    + "  ---  SUP ==> " + target_max_y + " --- ");
            if ((bullet_bottom_y < target_min_y) && (bullet_top_y >= target_min_y) )
            {
                Console.WriteLine("bersaglio colpito da sotto");
                target_hit = true;
            }

            // check if bullet (which is between the target) hit target
            if ((bullet_bottom_y >= target_min_y) && (bullet_top_y <= target_max_y))
            {
                //Console.WriteLine("bersaglio colpito in pieno");
                target_hit = true;
            }

            // check if bullet (which is on top of the target) hit target
            if ((bullet_bottom_y <= target_max_y) && (bullet_top_y > target_max_y))
            {
                Console.WriteLine("bersaglio colpito da sopra");
                target_hit = true;
            }
            // target not hitted
            if (target_hit == false)
            {
                Console.WriteLine("bersaglio non colpito");
            }
            Console.WriteLine(" --------------------------------------------------------------------- ");
        }

        // calculate vi_x
        public void calculateViX()
        {
            angle_radiants = Utilities.ToRadians(angle_degrees);
            //vi_x = speed * Math.Cos(angle_radiants);
            // add air speed opposition
            vi_x = speed * Math.Cos(angle_radiants) - air_speed * Math.Cos(angle_radiants);
        }

        // calculate vi_y
        public void calculateViY()
        {
            angle_radiants = Utilities.ToRadians(angle_degrees);
            //vi_y = speed * Math.Sin(angle_radiants);
            // add air speed opposition
            vi_y = speed * Math.Sin(angle_radiants) - air_speed * Math.Sin(angle_radiants);
        }

        // calculate final position
        public void calculateFinalPosition()
        {
            angle_radiants = Utilities.ToRadians(angle_degrees);
            final_position = vi_x * time_flight;
        }

        // function for calculate maximum height of bullet
        public void calculateMaxHeight()
        {
            angle_radiants = Utilities.ToRadians(angle_degrees);
            max_height = (vi_y * time_rise) - (0.5 * Utilities.g_power_acceleration * Math.Pow(time_rise, 2));
        }

        // calculate time rise
        public void calculateTimeRise()
        {
            time_rise = vi_y / Utilities.g_power_acceleration;     
        }

        // calculate time fall
        public void calculateTimeFall()
        {
            time_fall = Math.Sqrt((2 * max_height) / Utilities.g_power_acceleration);
        }

        // calculate time flight
        public void calculateTimeFlight()
        {
            time_flight = time_rise + time_fall;
        }

        // generate random valid position for target (if i want the bullet hit this)
        public void randomPositionForHitTarget()
        {
            // for directly changing values on input component
            //target_distance = Utilities.generateNumberRandom(final_position/2, final_position);
            //target_height=bullet_trajectory_current_position_y(target_distance);

            double x = Math.Round(Utilities.generateNumberRandom(final_position / 2, final_position), Utilities.number_round_decimal);
            double y = Math.Round(bullet_trajectory_current_position_y(x), Utilities.number_round_decimal);
            // Show on console the position
            Console.WriteLine("Move target to : [" + x + ", " + y + "] ");
        }

        public void calculateEnergy()
        {
            energy = 0.5 * mass * Math.Pow(speed, 2);
        }

        public void CalculateAirSpeedComponent()
        {
           // what should i do?
           // speed vs power !!
        }
    }
}
