using System;

namespace market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForStrawberrys = double.Parse(Console.ReadLine());
            double bananasInKg = double.Parse(Console.ReadLine());
            double orangesInKg = double.Parse(Console.ReadLine());
            double raspberryInKg = double.Parse(Console.ReadLine());
            double strawberryInKg = double.Parse(Console.ReadLine());
            double priceForRaspberry = priceForStrawberrys / 2;
            double priceForOranges = priceForRaspberry - (0.40 * priceForRaspberry);
            double priceForBananas = priceForRaspberry - (0.80 * priceForRaspberry);

            double sumForRaspberry = priceForRaspberry * raspberryInKg;
            double sumForOranges = priceForOranges * orangesInKg;
            double sumForBananas = priceForBananas * bananasInKg;
            double sumForStrawberrys = priceForStrawberrys * strawberryInKg;
            double totalSum = sumForRaspberry + sumForOranges + sumForBananas + sumForStrawberrys;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
