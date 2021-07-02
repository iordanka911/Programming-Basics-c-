using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            double desiredRevenue = double.Parse(Console.ReadLine());
            double income = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Party!")
                {
                    break;
                }
                int count = int.Parse(Console.ReadLine());
                double currentPrice = input.Length*count;

                if (currentPrice%2!=0)
                {
                    currentPrice *= 0.75;
                }
                income += currentPrice;
                if (income>=desiredRevenue)
                {
                    break;
                }
            }

            if (income>=desiredRevenue)
            {
                Console.WriteLine("Target acquired.");
            }
            else
            {
                double moneyNeeded = desiredRevenue - income;
                Console.WriteLine($"We need {moneyNeeded:f2} leva more.");
            }
            Console.WriteLine($"Club income - {income:f2} leva.");
        }
    }
}
