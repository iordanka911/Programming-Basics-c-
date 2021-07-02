using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOfEasterBread = int.Parse(Console.ReadLine());

            string topChef = "";
            int topGrade = 0;
            for (int i = 0; i < numOfEasterBread; i++)
            {

                string nameOfTheBaker = Console.ReadLine();
                string currentGrade = Console.ReadLine();
                int grades = 0;
                while (currentGrade != "Stop")
                {
                    var grade = int.Parse(currentGrade);
                    grades += grade;

                    currentGrade = Console.ReadLine();
                }
                Console.WriteLine($"{nameOfTheBaker} has {grades} points.");
                if (grades>topGrade)
                {
                    topGrade = grades;
                    topChef = nameOfTheBaker;

                    Console.WriteLine($"{topChef} is the new number 1!");
                }
            }
            Console.WriteLine($"{topChef} won competition with {topGrade} points!");
        }
    }
}
