using System;

namespace loops_exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < count; i++)
            {
                int current = int.Parse(Console.ReadLine());
                leftSum += current;
            }

            for (int i = 0; i < count; i++)
            {
                int current = int.Parse(Console.ReadLine());
                rightSum += current;
            }

            if (leftSum==rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {diff}");
            }



        }
        


        

    }
}
