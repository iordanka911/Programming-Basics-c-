using System;

namespace Number100200
{
    class Program
        {
        static void Main(string[] args)
        {
            const double rosesPrice = 5.00;
            const double DahliasPrice = 3.80;
            const double TulipsPrice = 2.80;
            const double NarcissusPrice = 3.00;
            const double GladiousPrice = 2.50;
            string flowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());
            double totalMoney = 0.0;
            if (flowers == "Roses")
            {
                if (numberOfFlowers > 80)
                {
                    totalMoney -= numberOfFlowers * rosesPrice * 0.10;
                }
                totalMoney += numberOfFlowers * rosesPrice;

            }
            else if (flowers == "Dahlias")
            {
                if (numberOfFlowers > 90)
                {
                    totalMoney -= numberOfFlowers * DahliasPrice * 0.15;
                }
                totalMoney += numberOfFlowers * DahliasPrice;
            }
            else if (flowers == "Tulips")
            {
                if (numberOfFlowers > 80)
                {
                    totalMoney -= numberOfFlowers * TulipsPrice * 0.15;
                }
                totalMoney += numberOfFlowers * TulipsPrice;
            }
            else if (flowers == "Narcissus")
            {
                if (numberOfFlowers < 120)
                {
                    totalMoney += numberOfFlowers * NarcissusPrice * 0.15;
                }
                totalMoney += numberOfFlowers * NarcissusPrice;
            }
            else if (flowers == "Gladiolus")
            {
                if (numberOfFlowers < 80)
                {
                    totalMoney += numberOfFlowers * GladiousPrice * 0.20;
                }
                totalMoney += numberOfFlowers * GladiousPrice;
            }
            if (budjet >= totalMoney)
                {
                    double moneyLeft = budjet - totalMoney;
                    Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowers} and {moneyLeft:f2} leva left.");
                }
                else
            {
                    double moneyNeeded = totalMoney - budjet;
                    Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }


        }
    }


}

