using System;

namespace Number100200
{
        class Program
        {
            static void Main(string[] args)
            {
            string type = Console.ReadLine();
            int raws = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double income = 0.0;
            if (type=="Premiere")
            {
                income = raws * colums * 12.00;
            }
             else  if (type == "Normal")
            {
                income = raws * colums * 7.50;
            }
            if (type == "Discount")
            {
                income = raws * colums * 5.00;
            }
            Console.WriteLine($"{income:f2} leva ");

        }
    }


}

