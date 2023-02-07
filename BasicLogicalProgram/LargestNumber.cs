using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class LargestNumber
    {
        public void LargestOfThreeNumber()
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                Console.WriteLine("The number {0} is gretest of all", a);
            else if (b > a && b > c)
                Console.WriteLine("The number {0} is gretest of all", b);
            else
                Console.WriteLine("The number {0} is gretest of all", c);
        }
    }
}
