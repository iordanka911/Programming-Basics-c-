using System;

namespace zoomarket
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int numberOfTheRestAnimals = int.Parse(Console.ReadLine());
            double onePackForDogs = 2.5;
            double onePackOtherAnimals = 4;
            double sum = numberOfDogs * onePackForDogs + numberOfTheRestAnimals * onePackOtherAnimals;
            Console.WriteLine($"{sum} lv.");

        }
    }
}
