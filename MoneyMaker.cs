using System;

/* This program converts a given amount of cents into gold, silver, and bronze coins, 
   using the fewest coins possible. */

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine();
            Console.WriteLine("Enter an amount to convert to coins:");

            // Ensure user enters a non-negative integer
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative whole number:");
            }

            Console.WriteLine();

            // Ternary operator to display input with proper pluralization
            Console.WriteLine($"{input} {(input == 1 ? "cent" : "cents")} is equal to...");

            int goldCoin = 10;
            int silverCoin = 5;
            int bronzeCoin = 1;

            // Calculate coins using integer arithmetic
            int goldCoins = input / goldCoin;
            int remainder = input % goldCoin;

            int silverCoins = remainder / silverCoin;
            remainder = remainder % silverCoin;

            int bronzeCoins = remainder / bronzeCoin;
            remainder = remainder % bronzeCoin;

            // Ternary operator to display results with proper pluralization
            Console.WriteLine($"{goldCoins} Gold {(goldCoins == 1 ? "coin" : "coins")}");
            Console.WriteLine($"{silverCoins} Silver {(silverCoins == 1 ? "coin" : "coins")}");
            Console.WriteLine($"{bronzeCoins} Bronze {(bronzeCoins == 1 ? "coin" : "coins")}");
        }
    }
}