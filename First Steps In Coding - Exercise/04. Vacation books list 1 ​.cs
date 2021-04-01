using System;

namespace vocationBookList
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberPages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int numberDaysBook = int.Parse(Console.ReadLine());
            double timeForBook = numberPages / pagesPerHour;
            double hoursPerDay = timeForBook / numberDaysBook;
            Console.WriteLine($"{hoursPerDay}");
        }
    }
}
