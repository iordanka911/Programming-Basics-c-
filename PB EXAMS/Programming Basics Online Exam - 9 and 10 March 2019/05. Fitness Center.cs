using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFitnessGuests = int.Parse(Console.ReadLine());
            int numBackActivity = 0;
            int numChestActivity = 0;
            int numLegActivity = 0;
            int numAbsActivity = 0;
            int numOfPeopleForProteinShake = 0;
            int numOfPeopleForProteinBar = 0;
            for (int i = 0; i < numberOfFitnessGuests; i++)
            {
                string activity = Console.ReadLine();
                switch (activity)
                {
                    case "Back":
                        numBackActivity++;
                       
                        break;
                    case "Chest":
                        numChestActivity++;
                        
                        break;
                    case "Legs":
                        numLegActivity++;
                        
                        break;
                    case "Abs":
                        numAbsActivity++;
                        
                        break;
                    case "Protein shake":
                        numOfPeopleForProteinShake++;
                        break;
                    case "Protein bar":
                        numOfPeopleForProteinBar++;
                        break;
                    
                    default:
                        break;
                        
                }
               
            }
            double totalWorkOut = (numAbsActivity + numBackActivity + numChestActivity + numLegActivity) / (numberOfFitnessGuests * 1.0) * 100;
            double totalProtein = (numOfPeopleForProteinBar + numOfPeopleForProteinShake) / (numberOfFitnessGuests * 1.0) * 100;

            Console.WriteLine($"{numBackActivity} - back");
            Console.WriteLine($"{numChestActivity} - chest");
            Console.WriteLine($"{numLegActivity} - legs");
            Console.WriteLine($"{numAbsActivity} - abs");
            Console.WriteLine($"{numOfPeopleForProteinShake} - protein shake");
            Console.WriteLine($"{numOfPeopleForProteinBar} - protein bar");
            Console.WriteLine($"{totalWorkOut:f2}% - work out");
            Console.WriteLine($"{totalProtein:f2}% - protein");

        }
    }
}
