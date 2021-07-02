using System;

namespace Basketball
{
    class Program
    {
        static void Main(string[] args)
        {
            int feeBasketball = int.Parse(Console.ReadLine());

            double sneakersForBasketball = feeBasketball - 0.40 * feeBasketball;
            double outfitBasketball = sneakersForBasketball - 0.20 * sneakersForBasketball;
            double ballForBasketball = 0.25 * outfitBasketball;
            double accessoariesForBasketball = 0.2 * ballForBasketball;
            double sumcosts = 0;
            sumcosts = feeBasketball + sneakersForBasketball + outfitBasketball + ballForBasketball + accessoariesForBasketball;
            Console.WriteLine($"{sumcosts:f2}");
        }
    }
}
