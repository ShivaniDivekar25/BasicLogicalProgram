﻿namespace BasicLogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bassic Logical Program");
            Console.WriteLine("1:Flip coin");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.FlipCoins();
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }    
        }
    }
}