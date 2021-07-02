using System;

namespace trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double spentValue = 0;
            if (budjet <= 100)
            {
                if (season == "summer")

                {
                    spentValue = 0.3 * budjet;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {spentValue:f2}");
                }
                else
                {
                    spentValue = 0.7 * budjet;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {spentValue:f2}");
                }

            }
            else if (budjet > 100 && budjet <= 1000)
            {
                if (season == "summer")
                {
                    spentValue = 0.4 * budjet;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {spentValue:f2}");
                }
                else
                {
                    spentValue = 0.8 * budjet;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {spentValue:f2}");
                }

            }
            else
            {
                spentValue = 0.9 * budjet;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {spentValue:f2}");
            }
           


        }
    }
}
