using System;

namespace Number100200
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            double area = 0;

            if (shape == "square")
            {

                double side = double.Parse(Console.ReadLine());

                area = side * side;
            }

            else if (shape == "rectangle")
            {

                double sideA = double.Parse(Console.ReadLine());

                double sideB = double.Parse(Console.ReadLine());

                area = sideA * sideB;
            }
            else if (shape == "circle")
            {

                double radius = double.Parse(Console.ReadLine());

                area = Math.PI*radius * radius;
            }
            else if (shape == "triangle")
            {

                double sideA = double.Parse(Console.ReadLine());

                double sideH = double.Parse(Console.ReadLine());

                area = 0.5*sideA * sideH;
            }
           

            Console.WriteLine($"{area:f3}");
        }
    }
}
