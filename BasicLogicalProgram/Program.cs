namespace BasicLogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bassic Logical Program");
            Console.WriteLine("1:Flip coin\n2:Leap Year\n3:Power of two");
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
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }    
        }
    }
}