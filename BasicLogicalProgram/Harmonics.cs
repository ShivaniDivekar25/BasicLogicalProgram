using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class Harmonics
    {
        public void HarmonicsSeries()
        {
            double value = 1;
            Console.WriteLine("Enter user input");
            double range = Convert.ToInt32(Console.ReadLine());
            for (int n = 1; n <= range; n++)
            {
                value = value + (1 / value);
            }
            Console.WriteLine("The harmonnic series is:" + value);
        }
    }
}
