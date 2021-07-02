using System;

namespace Number100200
{

    class Program
    {
        static void Main(string[] args)
        {

            int budjet = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishers = int.Parse(Console.ReadLine());
            double rentOfShip = 0;
            if (season == "Spring")
            {
                if (numberOfFishers <= 6) rentOfShip = 3000 - (0.1 * 3000);
                if (numberOfFishers >= 7 && numberOfFishers <= 11) rentOfShip = 3000 - (0.15 * 3000);
                if (numberOfFishers > 12) rentOfShip = 3000 - (0.25 * 3000);
                if (numberOfFishers % 2 == 0) rentOfShip -= rentOfShip * 0.05;
                if (budjet >= rentOfShip)
                { 
                    double moneyLeft = budjet - rentOfShip;
                    Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                }
                else
                {
                    double neededMoney = rentOfShip - budjet;
                    Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
                }
            }
            if (season == "Summer")
                {
                if (numberOfFishers <= 6) rentOfShip = 4200 - (0.1 * 4200);
                if (numberOfFishers >= 7 && numberOfFishers <= 11) rentOfShip = 4200 - (0.15 * 4200);
                if (numberOfFishers > 12) rentOfShip = 4200 - (0.25 * 4200);
                if (numberOfFishers % 2 == 0) rentOfShip -= rentOfShip * 0.05; 
                if (budjet >= rentOfShip)
                {
                    double moneyLeft = budjet - rentOfShip;
                    Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                }
                else
                {
                    double neededMoney = rentOfShip - budjet;
                    Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");

                }
            }
            if (season == "Autumn")
                 {
                if (numberOfFishers <= 6) rentOfShip = 4200 - (0.1 * 4200);
                if (numberOfFishers >= 7 && numberOfFishers <= 11) rentOfShip = 4200 - (0.15 * 4200);
                if (numberOfFishers > 12) rentOfShip = 4200 - (0.25 * 4200);
                if (budjet >= rentOfShip)
                {
                    double moneyLeft = budjet - rentOfShip;
                    Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                }
                else
                {
                    double neededMoney = rentOfShip - budjet;
                    Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");

                }
            }
            if (season == "Winter")
            {
                if (numberOfFishers <= 6) rentOfShip = 2600 - (0.1 * 2600);
                if (numberOfFishers >= 7 && numberOfFishers <= 11) rentOfShip = 2600 - (0.15 * 2600);
                if (numberOfFishers > 12) rentOfShip = 2600 - (0.25 * 2600);
                if (numberOfFishers % 2 == 0) rentOfShip -= rentOfShip * 0.05;
                if (budjet >= rentOfShip)
                {
                    double moneyLeft = budjet - rentOfShip;
                    Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                }
                else
                {
                    double neededMoney = rentOfShip - budjet;
                    Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");

                }
            }
           
        }
    }


}

