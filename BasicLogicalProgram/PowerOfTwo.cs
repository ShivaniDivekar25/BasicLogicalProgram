using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class PowerOfTwo
    {
        public void PowerOf2()
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                double res = Math.Pow(2, i);
                Console.WriteLine("The power of two is:" + res);
            }
        }
    }
}
