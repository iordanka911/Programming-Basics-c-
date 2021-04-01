using System;

namespace biggernumber
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            int isBigger = Math.Max(numOne, numTwo);
            Console.WriteLine(isBigger);
        }
    }
}
