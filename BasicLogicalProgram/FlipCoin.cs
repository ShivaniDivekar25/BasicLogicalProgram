using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class FlipCoin
    {
        float countHead = 0;
        float countTail = 0;
        public void FlipCoins()
        {
            Console.WriteLine("Please enter the number of times you want flip coin");
            int flipNum = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            for (int i = 0; i < flipNum; i++)
            {
                double numCheck = random.NextDouble();
                if (numCheck > 0.5)
                    countHead++;
                else
                    countTail++;
            }
            Console.WriteLine("The headcount is" + countHead);
            Console.WriteLine("The tailcount is" + countTail);
            float headPercentage = (countHead / flipNum) * 100;
            float tailPercentage = (countTail / flipNum) * 100;
            Console.WriteLine("Head count percentage is:" + headPercentage);
            Console.WriteLine("Tail count percentage is:" + tailPercentage);
        }
    }
}
