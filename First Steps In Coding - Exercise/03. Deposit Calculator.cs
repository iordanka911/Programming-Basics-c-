using System;

namespace greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            double timeForDeposit = double.Parse(Console.ReadLine());
            double annualIntPercent = double.Parse(Console.ReadLine())*0.01;

            double sum = depositSum + timeForDeposit * ((depositSum * annualIntPercent) / 12);
            
            Console.WriteLine($"{sum}");
        }
    }
}
