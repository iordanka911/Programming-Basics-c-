using System;

namespace FirstStepsInCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //const double courseOfDollars = 1.79549;
            double usd = double.Parse(Console.ReadLine());
            double convertBGN = usd * 1.79549;
            Console.WriteLine($"{convertBGN:f2}");
        }
    }
}
