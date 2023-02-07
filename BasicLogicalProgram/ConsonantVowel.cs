using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProgram
{
    public class ConsonantVowel
    {
        public void ConsonantOrVowel()
        {
            Console.WriteLine("Please provide input string");
            string input = Console.ReadLine();

            for (int i = 0; i <= input.Length; i++)
            {
                if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z'))
                {
                    if (input[i] == 'a' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'e' || input[i] == 'A' || input[i] == 'I' || input[i] == 'E' || input[i] == 'O' || input[i] == 'U')

                        Console.WriteLine("The alphabte {0} is vowel", input[i]);
                    else
                        Console.WriteLine("The alphabate {0} is consonant", input[i]);
                }
            }
        }
    }
}
