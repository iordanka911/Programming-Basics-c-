using System;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal coins = decimal.Parse(Console.ReadLine());
            int numCoins = 0;

            while (coins >= 2)
            {              
                 coins -= 2;
                 numCoins++;
            }
            while (coins >= 1)
            {
                coins -= 1;
                numCoins++;
            }
            while (coins >= 0.5m)
            {
                coins -= 0.5m;
                numCoins++;
            }
            while (coins >= 0.2m)
            {
                coins -= 0.2m;
                numCoins++;
            }
            while (coins >= 0.1m)
            {
                coins -= 0.1m;
                numCoins++;
            }
            while (coins >= 0.05m)
            {
                coins -= 0.05m;
                numCoins++;
            }
            while (coins >= 0.02m)
            {
                coins -= 0.02m;
                numCoins++;
            }
            while (coins >= 0.01m)
            {
                coins -= 0.01m;
                numCoins++;
            }

            Console.WriteLine(numCoins);
        }
    }
}
