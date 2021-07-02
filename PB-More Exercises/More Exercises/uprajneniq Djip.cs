            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string classOfCar = string.Empty;
            double priceForCar = 0;
            string typeOfCar = "";

            switch (classOfCar)
            {
                case "Economy class":
                    if (season == "Summer" && budjet <= 100)

                    {
                        //typeOfCar = "Cabrio";
                       // priceForCar = 0.35 * budjet;
                        Console.WriteLine("Cabrio");
                        Console.WriteLine($"Cabrio - {(0.35 * budjet):f2}");
                    }
                    if (season == "Winter" && budjet <= 100)
                    {
                        typeOfCar = "Jeep";
                        priceForCar = 0.65 * budjet;
                    }
                    break;
                case "Compact class":
                    if (season == "Summer" && budjet > 100 && budjet <= 500)
                    {
                        typeOfCar = "Cabrio";
                        priceForCar = 0.45 * budjet;
                    }
                    if (season == "Winter" && budjet > 100 && budjet <= 500)
                    {
                        typeOfCar = "Jeep";
                        priceForCar = 0.80 * budjet;
                    }
                    break;
                case "Luxury class":
                    if (budjet > 500)
                    {
                        typeOfCar = "Jeep";
                        priceForCar = 0.90 * budjet;
                    }
                    break;
                default:
                    break;
                    
            }             


using System;

namespace carForRent
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string classOfCar = string.Empty;
            double priceForCar = 0;
            string typeOfCar = "";

            if (budjet<=100)
            {
                classOfCar = "Economy class";
                switch (season)
                {
                    case "Summer":
                        typeOfCar = "Cabrio";
                        priceForCar = 0.35 * budjet;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"{classOfCar}");
            Console.WriteLine($"{typeOfCar} - {priceForCar:f2}");
                     
                       
        }
    }
}










using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSectorOfSectors = char.Parse(Console.ReadLine());
            int numOfRowsFirsSector = int.Parse(Console.ReadLine());
            int placesOfEvenRows =int.Parse(Console.ReadLine());
            
            
            int counter = 0;

            for (int sector =65; sector <=lastSectorOfSectors; sector++)
            {
                for (int row = 1; row <=numOfRowsFirsSector; row++)
                {
                    for (int place = 97; place <=122; place++)
                    {
                        counter++;
                        if (placesOfEvenRows%2==0)
                        {
                            place+=2;
                            break;
                        }
                        if (sector+1%2==0)
                        {

                        }
                        
                        
                        Console.WriteLine($"{Convert.ToChar(sector)}{row}{Convert.ToChar(place)}");
                    }
                }
            }
        }
    }
}


