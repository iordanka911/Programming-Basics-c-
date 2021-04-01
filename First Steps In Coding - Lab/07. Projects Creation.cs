using System;

namespace projects
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int oneProjectHours = 3;
            string nameOfTheArchitecht = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int neededHours = oneProjectHours * numberOfProjects;


            Console.WriteLine($"The architect {nameOfTheArchitecht} will need {neededHours} hours to complete {numberOfProjects} project/s.");
        }
    }
}
