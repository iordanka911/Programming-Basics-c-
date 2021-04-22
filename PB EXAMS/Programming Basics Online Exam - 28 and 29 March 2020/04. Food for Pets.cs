using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());
            double foodQuantity = double.Parse(Console.ReadLine());
            double biscuits = 0;
            double sumFoodForDogs = 0;
            double sumForCats = 0;
            for (int day = 1; day <= numDays; day++)
            {
                double foodQuantityDogPerDay = double.Parse(Console.ReadLine());
                double foodQuantityCatPerDay = double.Parse(Console.ReadLine());
                sumFoodForDogs += foodQuantityDogPerDay;
                sumForCats += foodQuantityCatPerDay;
                if (day%3==0)
                {
                   biscuits += 0.1 * (foodQuantityDogPerDay + foodQuantityCatPerDay);
                    
                }
                
            }
            double sumFoodEaten = sumFoodForDogs + sumForCats;
            double percentEatenFood = (sumFoodEaten / foodQuantity) * 100;
            double percentDog = (sumFoodForDogs/sumFoodEaten ) * 100;
            double percentCats = (sumForCats/sumFoodEaten) * 100;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{percentEatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentCats:f2}% eaten from the cat.");

        }
       
    }
}
