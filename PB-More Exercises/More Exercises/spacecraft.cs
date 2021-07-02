using System;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            double wigthOfTheShip = double.Parse(Console.ReadLine());
            double lenghtOfTheShip = double.Parse(Console.ReadLine());
            double heightOfTheShip = double.Parse(Console.ReadLine());
            double middleHeightOfAustronafts = double.Parse(Console.ReadLine());

            double volume = wigthOfTheShip * lenghtOfTheShip * heightOfTheShip;
            double volumeOneRoom = (middleHeightOfAustronafts + 0.40) * 2 * 2;
            double numPeopleSpace = Math.Floor(volume / volumeOneRoom);
            if (numPeopleSpace >= 3 && numPeopleSpace <= 10)
            {
                Console.WriteLine($"The spacecraft holds {numPeopleSpace} astronauts.");
            }
            if (numPeopleSpace < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            if (numPeopleSpace > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }

        }
    }
}


using System;

namespace gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());
            for (int i = M; i >=N; i--)
            {
                if (i%2==0&&i%3==0)
                {
                    Console.WriteLine($"{i}");
                }
                if (S==i)
                {
                    return;
                   
                }
            }
        }
    }
}

