using System;

namespace scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());
            double priceYard = squareMeters * 7.61;
            double discount = 0.18 * priceYard;
            double finalPrice = priceYard - discount;
            Console.WriteLine($"The final price is: {finalPrice:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
