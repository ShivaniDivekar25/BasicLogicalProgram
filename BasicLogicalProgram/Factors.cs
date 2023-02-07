using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class Factors
    {
        public void FactorsNumber()
        {
            Console.WriteLine("Enter the input value");
            int input = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    count = 1;
                    Console.WriteLine("The {0} is factor of {1}", i, input);
                }
                for (int j = 2; j <= i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        count = 0;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine("The {0} is prime factor", i);
                }
            }
        }
    }
}
