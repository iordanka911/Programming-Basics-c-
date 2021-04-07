using System;

namespace Godzilla
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double budjet = double.Parse(Console.ReadLine());
                double superNumerary = double.Parse(Console.ReadLine());
                double priceForDressOneSupNumerary = double.Parse(Console.ReadLine());
                double priceForDecor = budjet * 0.10;
                double priceForDress = superNumerary * priceForDressOneSupNumerary;



                if (superNumerary > 150)
                {
                    double discount = priceForDress * 0.10;
                    priceForDress -= discount;
                }
                double priceForFilm = priceForDecor + priceForDress;
                if (budjet < priceForFilm)
                {
                    double neededMoney = priceForFilm - budjet;
                    Console.WriteLine($"Not enough money!");
                    Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
                }
                else
                {
                    double moneyLeft = budjet - priceForFilm;
                    Console.WriteLine($"Action!");
                    Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
                }



            }
        }
    }
}

