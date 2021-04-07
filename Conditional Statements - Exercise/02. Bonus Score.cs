using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStart = int.Parse(Console.ReadLine());
            double bonus = 0;
            
                if (numberStart <= 100)
            {
                bonus+= 5;
            }
                                
               else if (numberStart>1000)
            {
                bonus = 0.1 * numberStart;
            }
            else if (numberStart > 100)
            {
                bonus = 0.2 * numberStart;
            }
            if (numberStart%2==0)
            {
                bonus = bonus + 1;
            }
                else if(numberStart%10==5)
            {
                bonus = bonus+ 2;
            }
            Console.WriteLine($"{bonus}");
            double finalSum = numberStart + bonus;
            Console.WriteLine($"{finalSum}");

        }
    }
}
