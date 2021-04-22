using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            double trunkCapacity = double.Parse(Console.ReadLine());
            int suitCasesCounter = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine("Congratulations! All suitcases are loaded!");
                    break;
                }
                else
                {
                    double volumeTrunk = double.Parse(input);
                    suitCasesCounter++;

                    if (suitCasesCounter % 3 == 0)
                    {
                        volumeTrunk += volumeTrunk * 0.10;
                    }

                    if (trunkCapacity < volumeTrunk)
                    {
                        suitCasesCounter--;
                        Console.WriteLine("No more space!");
                        break;
                    }

                    trunkCapacity -= volumeTrunk;
                }
            }

            Console.WriteLine($"Statistic: {suitCasesCounter} suitcases loaded.");
        }
    }
}
