using System;

namespace stranakvadrat
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayofStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string value = Console.ReadLine();
            double priceOfRest = 0;
            dayofStay -= 1;
            if (typeOfRoom == "room for one person")
                priceOfRest = dayofStay * 18;
            if (typeOfRoom=="apartment")
            {
                if (dayofStay < 10) priceOfRest = (25 * dayofStay)-(0.3*25*dayofStay);
                if (dayofStay > 10 && dayofStay < 15) priceOfRest = (25 * dayofStay)-(0.35*25*dayofStay);
                if (dayofStay > 15) priceOfRest = (25 * dayofStay)-(0.5*25*dayofStay);

            }
            if (typeOfRoom == "president apartment")
            {
                if (dayofStay < 10) priceOfRest = (35 * dayofStay) - (0.1 * 35 * dayofStay);
                if (dayofStay > 10 && dayofStay < 15) priceOfRest = (35 * dayofStay) - (0.15 * 35 * dayofStay);
                if (dayofStay > 15) priceOfRest = (35 * dayofStay)-(0.2*35*dayofStay);

            }
            if (value == "positive")
            {
                priceOfRest += priceOfRest * 0.25;
            }
            if (value=="negative")
            {
                priceOfRest -= priceOfRest * 0.1;
            }
            Console.WriteLine($"{priceOfRest:f2}");
        }
    }
}
