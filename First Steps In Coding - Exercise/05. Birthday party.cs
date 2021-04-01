using System;

namespace vocationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentHall = double.Parse(Console.ReadLine());
            double cakePrice = 0.20 * rentHall;
            double priceDrinks = cakePrice - (0.45 * cakePrice);
            double priceAnimator = 0.3333333333333333 * rentHall;
            double neededMoney = rentHall + cakePrice + priceDrinks + priceAnimator;
            Console.WriteLine($"{ neededMoney}");
            
        }
    }
}
