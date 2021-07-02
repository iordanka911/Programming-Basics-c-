using System;

namespace Number100200
{

    class Program
    {
        static void Main(string[] args)
        {

            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {

                if (fruit == "banana") price = quantity * 2.50;
                if (fruit == "apple") price = quantity * 1.20;
                if (fruit == "orange") price = quantity * 0.85;
                if (fruit == "grapefruit") price = quantity * 1.45;
                if (fruit == "kiwi") price = quantity * 2.70;
                if (fruit == "pineapple") price = quantity * 5.50;
                if (fruit == "grapes") price = quantity * 3.85;
                             
            }
           
            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                {
                    if (fruit == "banana") price = quantity * 2.70;
                    if (fruit == "apple") price = quantity * 1.25;
                    if (fruit == "orange") price = quantity * 0.90;
                    if (fruit == "grapefruit") price = quantity * 1.60;
                    if (fruit == "kiwi") price = quantity * 3.00;
                    if (fruit == "pineapple") price = quantity * 5.60;
                    if (fruit == "grapes") price = quantity * 4.20;                                     
                }
                
            }
            if (price > 0)
            {
                Console.WriteLine($"{price:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
