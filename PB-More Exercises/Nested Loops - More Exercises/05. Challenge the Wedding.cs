using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMans = int.Parse(Console.ReadLine());
            int numWomens = int.Parse(Console.ReadLine());
            int MaxNumberTabeles = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= numMans; i++)
            {
                for (int j = 1; j <= numWomens; j++)
                {
                    Console.Write($"({i} <-> {j}) ");
                    counter++;
                    if (counter == MaxNumberTabeles)
                    {
                        return;
                    }
                    
                }

            }

        }
    }
}
