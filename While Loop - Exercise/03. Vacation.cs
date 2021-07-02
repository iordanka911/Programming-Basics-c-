using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double target= double.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());
            int days=0;
            int spendDays = 0;
            bool isEnough = false;
            while (!isEnough)
            {
                string command = Console.ReadLine();
                double amountMoney = double.Parse(Console.ReadLine());
                days++;
                if (command=="save")
                {
                    budjet += amountMoney;
                    spendDays = 0;
                }
                else
                {
                    budjet -= amountMoney;
                    if (budjet<0)
                    {
                        budjet = 0;
                    }
                    spendDays++;
                    if (spendDays>=5)
                    {
                        break;
                    }
                }
                if (budjet>=target)
                {
                   isEnough=true;
                    
                }

            }
            if (isEnough)
            {
                Console.WriteLine($"You saved the money for {days} days.");
               
            }

            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            
          
        }
    }
}
