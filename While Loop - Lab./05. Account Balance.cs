using System;

namespace while_exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;
           
            while (true)
            {
                string inputSum = Console.ReadLine();
               if (inputSum == "NoMoreMoney")
                {
                    break;
                }
                double deposit = double.Parse(inputSum);
                if (deposit<=0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    balance += deposit;
                    Console.WriteLine($"Increase: {deposit:f2}");
                   
                }
                
                
            }

            Console.WriteLine($"Total: {balance:f2}");
        }

    }
}
