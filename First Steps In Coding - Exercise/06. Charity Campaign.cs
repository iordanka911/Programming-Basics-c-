using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfCookers = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());
            double sumForComp = (numberOfCakes * 45 + numberOfWaffles * 5.80 + numberOfPancakes * 3.20) * numberOfDays*numberOfCookers;
            double finalSum = sumForComp - 0.125 * sumForComp;
            Console.WriteLine($"{finalSum}");


        }
    }
}
