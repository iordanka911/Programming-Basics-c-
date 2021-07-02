using System;

namespace loops_exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string userName = Console.ReadLine();
            string inputPassword = Console.ReadLine();
            string input = Console.ReadLine();
            while (inputPassword != input)
            {
                input = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {userName}!");

        }


    }
}
