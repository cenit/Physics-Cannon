using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Progetto_Fisica
{
    class Utilities
    {
        /********************************************************************
        * PROPERTIES
        ********************************************************************/
        // graph constant
        public static int   GRAPH_ELEMENTS_NUMBER = 500;
        public static double GRAPH_CURVE_INCREMENT = 1;
        // generic constant
        public static int     number_round_decimal = 4;
        public static double  air_friction_coefficient = (1.5 * 0.000005);
        public static double  g_power_acceleration = 9.7803184; // 4.8902

        /********************************************************************
         * METHODS
         *********************************************************************/
        // function for convert angle from degrees to radians
        public static double ToRadians(double val)
        {
            return (Math.PI / 180) * val;
        }

        // find the max value in a <double> array
        public static double maxValue(double[] array)
        {
            double max = 0;
            for(int i=0; i<array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        // function for counting decimal digit of a input number
        public static int countDecimalDigits(double argument)
        {
            try
            {
                return BitConverter.GetBytes(decimal.GetBits((decimal)argument)[3])[2];
            }
            catch(Exception ex)
            {
                Console.WriteLine("Eccezione Generata: " + ex.Message);
            }
            return 0;
        }

        // generate random (double) number between min and max values
        public static double generateNumberRandom(double min_value, double max_value)
        {
            Random random = new Random();
            return random.NextDouble() * (max_value - min_value) + min_value;
        }



    }
}
