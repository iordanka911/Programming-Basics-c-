using System;

namespace toyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForExcursion = double.Parse(Console.ReadLine());
            int numberPuzzles = int.Parse(Console.ReadLine());
            int numTalkingDolls = int.Parse(Console.ReadLine());
            int numToyBears = int.Parse(Console.ReadLine());
            int numMinions = int.Parse(Console.ReadLine());
            int numTrucks = int.Parse(Console.ReadLine());

            double earnedMoney = numberPuzzles *2.60+numTalkingDolls*3+numToyBears*4.10+numMinions*8.20+numTrucks*2;
            int numberOfToys = numberPuzzles + numMinions + numTalkingDolls + numToyBears + numTrucks;
            if (numberOfToys>=50)
            {
                earnedMoney = earnedMoney - (0.25 * earnedMoney);
            }
            double finalProfit = earnedMoney - (0.10 * earnedMoney);
            if (finalProfit >= priceForExcursion)
            {
                Console.WriteLine($"Yes! {finalProfit - priceForExcursion:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceForExcursion-finalProfit:f2} lv needed.");
            }

        }
    }
}
