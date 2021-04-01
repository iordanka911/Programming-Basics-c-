using System;

namespace aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int high = int.Parse(Console.ReadLine());
            int wide = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            int volume = high * wide * lenght;
            double allLiters = volume * 0.001;
            double somePercent = percent * 0.01;
            double litersNeeded = allLiters * (1 - somePercent);
            Console.WriteLine($"{litersNeeded:f3}");
        }
    }
}
