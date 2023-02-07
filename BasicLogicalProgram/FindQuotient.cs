using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class FindQuotient
    {
        public void FindQuotients()
        {
            Console.WriteLine("Enter Divident value");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor value");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = Math.DivRem(divident, divisor, out int reminder);
            Console.WriteLine("The quotient is:" + quotient);
            Console.WriteLine("The remainder is:" + reminder);
        }
    }
}
