using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class EvenOrOdd
    {
        public void FindEvenOrOdd()
        {
            Console.WriteLine("Enter number to find even or odd");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("The given number is even");
            else
                Console.WriteLine("The given number is odd");
        }
    }
}
