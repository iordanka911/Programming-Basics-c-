using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            int jouryCont = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int gradeCount = 0;
            double sumOfAllGrades = 0;

            while (input != "Finish")
            {
                double sumOfGrades = 0;
                for (int i = 1; i <= jouryCont; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGrades += grade;
                    gradeCount++;
                    sumOfAllGrades += grade;
                }

                double average = sumOfGrades / jouryCont;
                Console.WriteLine($"{input} - {average:f2}.");
                input = Console.ReadLine();
            }

            double finalAverage = sumOfAllGrades / gradeCount;
            Console.WriteLine($"Student's final assessment is {finalAverage:f2}.");



        }
    }
}