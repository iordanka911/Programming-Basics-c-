using System;

namespace NewTask
{
    class Program
    {
        static void Main(string[] args)
        {

            string year= Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            if (year == "normal")
            {
                
                int weekendInSofia = 48 - h;
                double saturdayGamesSofia = weekendInSofia * 0.75;
                double gamesInHoliday = p * 0.66666666666666666666666666666667;
                double gamesHomeTown = h;
                double allGames = saturdayGamesSofia + gamesInHoliday + gamesHomeTown;
                {
                    Console.WriteLine($"{Math.Floor(allGames)}");
                }
            }
            
            if (year=="leap")
            {
                int weekendInSofia = 48 - h;
                double saturdayGamesSofia = weekendInSofia * 0.75;
                double gamesInHoliday = p * 0.66666666666666666666666666666667;
                double gamesHomeTown = h;
                double allGames = saturdayGamesSofia + gamesInHoliday + gamesHomeTown;
                double  allGamesLeap = allGames + allGames * 0.15;
                {
                    Console.WriteLine($"{Math.Floor(allGamesLeap)}");
                }
            }
            
        }
    }
}
