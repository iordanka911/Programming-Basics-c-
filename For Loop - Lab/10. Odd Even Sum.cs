using System;

namespace loops_exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            int rightSum = 0;
            for (int i = 1; i <= count; i++)
            {
                int current= int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += current;
                }

                else
                {
                    oddSum += current;
                }

            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }

            else
            {
                int diff = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }


        }

    }
}
