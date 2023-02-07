namespace BasicLogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bassic Logical Program");
            Console.WriteLine("1:Flip coin\n2:Leap Year\n3:Power of two\n4:Harmonics\n5:Find Quotient\n6:Swapping Numbers\n7:Even Odd Numbers\n8:Consonant Vowel\n9:Largest Number\n10:Factors of Number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.FlipCoins();
                    break;
                case 2:
                    LeapYear leapYear = new LeapYear();
                    leapYear.LeapYears();
                    break;
                case 3:
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    powerOfTwo.PowerOf2();
                    break;
                case 4:
                    Harmonics harmonics = new Harmonics();
                    harmonics.HarmonicsSeries();
                    break;
                case 5:
                    FindQuotient findQuotient = new FindQuotient();
                    findQuotient.FindQuotients();
                    break;
                case 6:
                    SwappingNumbers swapingNumbers = new SwappingNumbers();
                    swapingNumbers.SwappingTwoNumbers();
                    break;
                case 7:
                    EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.FindEvenOrOdd();
                    break;
                case 8:
                    ConsonantVowel consonantVowel = new ConsonantVowel();
                    consonantVowel.ConsonantOrVowel();
                    break;
                case 9:
                    LargestNumber largestNumber = new LargestNumber();
                    largestNumber.LargestOfThreeNumber();
                    break;
                case 10:
                    Factors factors = new Factors();
                    factors.FactorsNumber();
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }    
        }
    }
}