using System;

namespace Loops_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 1000; num++)
            {
                if (num%10==7)
                {
                    Console.WriteLine(num);
                }

            }
        }
    }
}

