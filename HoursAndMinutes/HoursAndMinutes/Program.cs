using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            calculateHoursAndMinutes(); 
        }

        public static void calculateHoursAndMinutes()
        {
            int minutes = 198;
            int hours = minutes / 60;
            int leftOverMinutes = minutes % 60;

            System.Console.WriteLine(minutes  + " Minutes Becomes: " + hours + " Hours and " + leftOverMinutes + " minutes" );
            System.Console.ReadKey(); 
        }
    }
}
