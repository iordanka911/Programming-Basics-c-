using System;

namespace ChrismasToys
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearsOfPeopleFromFamily = Console.ReadLine();
            int numberOfAdults = 0;
            int numberOfKids = 0;
            int moneyForToys = 0;
            int moneyForSweaters = 0;
            int numberOfToys = 0;
            int numberOfSweaters = 0;
            while (yearsOfPeopleFromFamily!="Chrismas")
            {
                int years = int.Parse(yearsOfPeopleFromFamily);
                if (years<=16)
                {
                    numberOfKids++;
                    numberOfToys++;
                    moneyForToys= numberOfToys * 5;
                }
                if (years>16)
                {
                    numberOfAdults++;
                    numberOfSweaters++;
                    moneyForSweaters= numberOfSweaters * 15;

                }
                yearsOfPeopleFromFamily = Console.ReadLine();
            }

            if (yearsOfPeopleFromFamily=="Chrismas")
            {
                Console.WriteLine($"Number of adults: {numberOfAdults}");
                Console.WriteLine($"Number of kids: {numberOfKids}");
                Console.WriteLine($"Money for toys: {moneyForToys}");
                Console.WriteLine($"Money for sweaters: {moneyForSweaters}");
            }
            
           
        }
    }
}



using System;

namespace gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());
            for (int i = M; i >= N; i--)
            {
                
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (S == i)
                    {
                        return;

                    }
                    Console.Write($"{i} ");
                }
                

            }
        }
    }
}


