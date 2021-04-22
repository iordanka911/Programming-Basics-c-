using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalking = int.Parse(Console.ReadLine());
            int numbersOfWalkingPerDay = int.Parse(Console.ReadLine());
            int numberOfCaloriesPerDay = int.Parse(Console.ReadLine());

            int allMinutesForWalking = minutesWalking * numbersOfWalkingPerDay;
            int allCalories = allMinutesForWalking * 5;
            double expectedCalories = 0.50 * numberOfCaloriesPerDay;
            if (allCalories>=expectedCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {allCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {allCalories}.");
            }

           
        }
    }
}
