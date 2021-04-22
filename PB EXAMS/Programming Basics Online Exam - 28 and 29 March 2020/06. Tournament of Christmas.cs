using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDaysTournament = int.Parse(Console.ReadLine());
            double money = 0;
            int daysWon = 0;
            int daysLost = 0;

            for (int i = 1; i <= numOfDaysTournament; i++)
            {
                int gamesWon = 0;
                int gamesLost = 0;
                double dailyMoney = 0;
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input=="Finish")
                    {
                        break;
                    }
                    string result = Console.ReadLine();
                    if (result=="win")
                    {
                        gamesWon++;
                        dailyMoney += 20;
                    }
                    else if (result=="lose")
                    {
                        gamesLost++;
                    }
                }
              
                if (gamesWon > gamesLost)
                {
                        daysWon++;
                        dailyMoney = dailyMoney + dailyMoney * 0.1;
                        money += dailyMoney;
                }
                else
                {
                        daysLost++;
                        money += dailyMoney;
                }
                
               

            }
                   
                if (daysWon>daysLost)
                {
                    double finalSum = money + money * 0.2;
                    Console.WriteLine($"You won the tournament! Total raised money: {finalSum:f2}");
                }
                          
                else
                {
                Console.WriteLine($"You lost the tournament! Total raised money: {money:f2}");
                }

        }
    }
}
