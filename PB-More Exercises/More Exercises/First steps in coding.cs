13.	First Steps in Coding - More Exercises
.01. Trapeziod Area
using System;

namespace NewTask
{
    class Program
    {
        static void Main(string[] args)
        {

            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = 0;
            area = (b1 + b2) * h / 2;
            
                Console.WriteLine($"{area:f2}");
            
            
        }
    }
}

02. Triangle Area
using System;


namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = side * h / 2;
            Console.WriteLine($"{area:f2}");
        }
    }
}

03. Celsius to Fahrenheit
using System;


namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            double degreesCelsius = double.Parse(Console.ReadLine());
            double degreesFarenheight = degreesCelsius * 1.8 + 32;
            Console.WriteLine($"{degreesFarenheight:f2}");
        }
    }
}


04. Зеленчукова борса

using System;


namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceKgVegetables = double.Parse(Console.ReadLine());
            double priceKgFruits = double.Parse(Console.ReadLine());
            int kgVegetables = int.Parse(Console.ReadLine());
            int kgFruits = int.Parse(Console.ReadLine());
            const double courseOfEuro = 1.94;
            double income = 0;
            income = priceKgVegetables * kgVegetables + priceKgFruits * kgFruits;
            double incomeEuro = income / courseOfEuro;
            Console.WriteLine($"{incomeEuro:f2}");

        }
    }
}

05.Боядисване на къща
using System;


namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightOfHouse = double.Parse(Console.ReadLine());
            double lenghtOfTheSideWallHouse = double.Parse(Console.ReadLine());
            double heightOfTheTriangle = double.Parse(Console.ReadLine());

            double sumForWalls = (2*heightOfHouse * lenghtOfTheSideWallHouse + 2*heightOfHouse * heightOfHouse) - (1.2 * 2 + 2 * 1.5 * 1.5);
            double greenColor = sumForWalls / 3.4;
            double sumForRoof = 2 * ((heightOfHouse * heightOfTheTriangle)/2) + 2 * heightOfHouse * lenghtOfTheSideWallHouse;
            double redColor = sumForRoof / 4.3;
            Console.WriteLine($"{greenColor:f2}");
            Console.WriteLine($"{redColor:f2}");

        }
    }
}
06.Учебна зала
using System;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double places = 0;
            if (h>=3&&h<=w&&w<=100)
            {
                double hInCm = h * 100;
                double desksOnRow = Math.Floor((hInCm - 100) / 70);
                double wInCm = w * 100;
                double rows = Math.Floor(wInCm / 120);
                places = desksOnRow * rows - 3;
            }
            Console.WriteLine(places);
        }
    }
}

07. Рибна Борса
using System;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceMackerelKg = double.Parse(Console.ReadLine());
            double spratPriceKg = double.Parse(Console.ReadLine());
            double bonitoKg = double.Parse(Console.ReadLine());
            double scadKg = double.Parse(Console.ReadLine());
            double musselsKg = double.Parse(Console.ReadLine());
            double sum = 0;
            double priceBonitoKg = priceMackerelKg + 0.60 * priceMackerelKg;
            double priceScadForKg = spratPriceKg + 0.80 * spratPriceKg;
            double priceMussels = 7.5;
            sum = bonitoKg * priceBonitoKg + scadKg * priceScadForKg + musselsKg * priceMussels;
            Console.WriteLine($"{sum:f2}");


        }
    }
}

08.Периметър и лице на кръг

using System;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double calculatedArea = Math.PI*r*r;
            double calculatedPerimeter = 2 * Math.PI * r;
            Console.WriteLine($"{calculatedArea:f2}");
            Console.WriteLine($"{calculatedPerimeter:f2}");


        }
    }
}

09. Weather Forecast

Допълнителни задачи
Сумиране на числа

using System;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sum = 0;
            while (command!="stop")
            {
                int number = int.Parse(command);
                sum += number;
                command = Console.ReadLine();
;
            }
            Console.WriteLine(sum);
        }
    }
}

using System;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            
            while (command!="stop")
            {
                int number = int.Parse(command);
                sum -= number;
                command = Console.ReadLine();

            }
            Console.WriteLine(sum);

        }
    }
}
