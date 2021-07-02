using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int volume = width * length * height;
            bool hasVolume = true;

            string command = Console.ReadLine();
            while (!(command == "Done"))
            {
                int box = int.Parse(command);
                volume -= box;
                if (volume < 0)
                {
                    hasVolume = false;
                    break;
                }
                command = Console.ReadLine();
            }
            if (hasVolume)
                Console.WriteLine("{0} Cubic meters left.", volume);
            else
                Console.WriteLine("No more free space! You need {0} Cubic meters more.", Math.Abs(volume));


        }
    }
}

