using System;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFilms = int.Parse(Console.ReadLine());
            double maxRating = 0;
            double lowestRating = 0;
            double sumRatings = 0;
            string nameOfFilmHighestRating = "";
            string nameOfTheFilmLowestRating = "";
            for (int i = 1; i <=numFilms; i++)
            {
                string nameOfTheFilm = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                if (rating>=maxRating)
                {
                    maxRating=rating;
                    nameOfFilmHighestRating = nameOfTheFilm;
                  
                }
                else
                {
                    lowestRating=rating;
                    nameOfTheFilmLowestRating = nameOfTheFilm;
                   
                }
                sumRatings += rating;
                
            }
            Console.WriteLine($"{nameOfFilmHighestRating} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{nameOfTheFilmLowestRating} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {sumRatings/numFilms:f1}");
        }
    }
}
