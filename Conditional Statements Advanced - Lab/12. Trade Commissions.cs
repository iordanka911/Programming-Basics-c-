using System;

namespace Number100200
{

    class Program
        {
        static void Main(string[] args)
        {
            string nameOfTown = Console.ReadLine();
            double volumeOfSells = double.Parse(Console.ReadLine());
            double saleComission = 0.0;
            if (nameOfTown == "Sofia")
            {

                if (volumeOfSells >= 0 && volumeOfSells <= 500) saleComission = volumeOfSells * 0.05;
                if (volumeOfSells > 500 && volumeOfSells <= 1000) saleComission = volumeOfSells * 0.07;
                if (volumeOfSells > 1000 && volumeOfSells <= 10000) saleComission = volumeOfSells * 0.08;
                if (volumeOfSells > 10000) saleComission = volumeOfSells * 0.12;
            }
            else if (nameOfTown == "Varna")
            {
                if (volumeOfSells >= 0 && volumeOfSells <= 500) saleComission = volumeOfSells * 0.045;
                if (volumeOfSells > 500 && volumeOfSells <= 1000) saleComission = volumeOfSells * 0.075;
                if (volumeOfSells > 1000 && volumeOfSells <= 10000) saleComission = volumeOfSells * 0.10;
                if (volumeOfSells > 10000) saleComission = volumeOfSells * 0.13;
            }
            else if (nameOfTown == "Plovdiv")
            {
                if (volumeOfSells >= 0 && volumeOfSells <= 500) saleComission = volumeOfSells * 0.055;
                if (volumeOfSells > 500 && volumeOfSells <= 1000) saleComission = volumeOfSells * 0.08;
                if (volumeOfSells > 1000 && volumeOfSells <= 10000) saleComission = volumeOfSells * 0.12;
                if (volumeOfSells > 10000) saleComission = volumeOfSells * 0.145;
            }
            if (saleComission <= 0)
            {
                Console.WriteLine("error");
            }
            else
            { 
                Console.WriteLine($"{saleComission:f2}");
            }
           
                   
                        
        }
    }


}

