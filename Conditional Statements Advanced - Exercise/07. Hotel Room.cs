using System;

namespace NewTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double numberOfOvernight = double.Parse(Console.ReadLine());
            double priceOfRestStudio = 0;
            double priceOfRestApartment = 0;
            if (month == "May" || month == "October")
            {
                if (numberOfOvernight <= 14)
                {
                    priceOfRestApartment = 65 * numberOfOvernight;


                }
                else if (numberOfOvernight > 14)
                {
                    priceOfRestApartment = (65 - (0.1 * 65)) * numberOfOvernight;

                }
            }
            if (month == "May" || month == "October")
            {
                if (numberOfOvernight <= 7)
                {
                    priceOfRestStudio = 50 * numberOfOvernight;

                }
                else if (numberOfOvernight > 7 && numberOfOvernight <= 14)
                {
                    priceOfRestStudio = (50 - (0.05 * 50)) * numberOfOvernight;

                }
                else if (numberOfOvernight > 14)
                {
                    priceOfRestStudio = (50 - (0.3 * 50)) * numberOfOvernight;
                }

            }
            if (month == "June" || month == "September")
            {
                if (numberOfOvernight <= 14)
                {
                    priceOfRestApartment = 68.70 * numberOfOvernight;


                }
                else if (numberOfOvernight > 14)
                {
                    priceOfRestApartment = (68.70 - (0.1 * 68.70)) * numberOfOvernight;

                }
            }
            if (month == "June" || month == "September")
            {
                if (numberOfOvernight <= 14)
                {
                    priceOfRestStudio = 75.20 * numberOfOvernight;

                }
                else if (numberOfOvernight > 14)
                {
                    priceOfRestStudio = (75.20 - (0.2 * 75.20)) * numberOfOvernight;
                }

            }
            if (month == "July" || month == "August")
            {
                if (numberOfOvernight <= 14)
                {
                    priceOfRestApartment = 77 * numberOfOvernight;
                }
                else if (numberOfOvernight > 14)
                {
                    priceOfRestApartment = (77 - (0.1 * 77)) * numberOfOvernight;
                }
            }
            if (month == "July" || month == "August")
            {
                priceOfRestStudio = 76 * numberOfOvernight;
            }

            Console.WriteLine($"Apartment: {priceOfRestApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceOfRestStudio:f2} lv.");

        }
    }
}
