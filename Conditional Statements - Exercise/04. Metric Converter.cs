using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputNumber  = double.Parse(Console.ReadLine());
            string enterUnit = Console.ReadLine();
            string exitUnit = Console.ReadLine();
            if (enterUnit == "mm" && exitUnit=="m")
            {
                inputNumber /= 1000;
            }
            else if (enterUnit=="m"&&exitUnit=="mm")
            {
                inputNumber *= 1000;
            }
            else if (enterUnit == "cm" && exitUnit == "m")
            {
                inputNumber *= 0.01;
            }
            else if (enterUnit == "m" && exitUnit == "cm")
            {
                inputNumber *= 100;
            }
            else if (enterUnit == "mm" && exitUnit == "cm")
            {
                inputNumber /= 10;
            }
            else if (enterUnit == "cm" && exitUnit == "mm")
            {
                inputNumber *= 10;
            }
            Console.WriteLine($"{inputNumber:f3}");
        }
    }
}
