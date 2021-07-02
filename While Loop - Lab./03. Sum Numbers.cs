using System;

namespace loops_exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            int sum = 0;

            while (true)
            {
                int curentNum = int.Parse(Console.ReadLine());
                sum += curentNum;
                if (sum>=target)
                {
                    break;
                }
            }
            Console.WriteLine(sum);

        }

    }
}
