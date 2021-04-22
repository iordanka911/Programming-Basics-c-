using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            double detergentForCleaning = double.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());
            double sum = (pens * 5.80) + (markers * 7.20) + (detergentForCleaning * 1.20);
            double finalSum = sum - (sum * percentDiscount * 0.01);
            Console.WriteLine($"{finalSum:f3}");
        }
    }
}
