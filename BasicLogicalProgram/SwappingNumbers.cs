using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class SwappingNumbers
    {
        public void SwappingTwoNumbers()
        {
            Console.WriteLine("Please enter number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number before swaping {0} and {1}", i, j);
            int temp = i;
            i = j;
            j = i;
            Console.WriteLine("The number after swapping {0} and {1}", i, j);

        }
    }
}
