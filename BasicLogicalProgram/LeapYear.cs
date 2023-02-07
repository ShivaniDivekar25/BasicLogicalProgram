using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class LeapYear
    {
        public void LeapYears()
        {
            Console.WriteLine("Please enter year you want to find");
            int Year = Convert.ToInt32(Console.ReadLine());

            if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
            {
                Console.WriteLine("The {0} is leap year", Year);
            }
            else
            {
                Console.WriteLine("The {0} is not leap year", Year);
            }
        }
    }
}
