namespace BasicLogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bassic Logical Program");
            Console.WriteLine("1:Flip coin\n2:Leap Year\n3:Power of two\n4:Harmonics\n5:Find Quotient");
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
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }    
        }
    }
}