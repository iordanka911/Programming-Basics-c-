using System;

namespace loops_exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < count; i++)
            {
                int current = int.Parse(Console.ReadLine());
               
                if (current > max)
                {
                    max = current;
                }

                if(current<min)
                {
                    min = current;
                    
                }
                
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");



        }
        


        

    }
}
