using System;

namespace loops_exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count= int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            bool isBancrupt=false;
            for (int i = 0; i < count; i++)
            {
                    string nameOfSite = Console.ReadLine();
                switch (nameOfSite)
                {
                    case "Facebook":
                         salary -= 150;
                        break;
                    case "Instagram":
                         salary -= 100;
                        break;
                    case "Reddit":
                    salary -= 50;
                        break;
                
                }
            
                  if (salary<=0)
                  {
                    Console.WriteLine("You have lost your salary.");
                    isBancrupt = true;
                    break;
                  }
            }
            
            if (!isBancrupt)
            {
                Console.WriteLine($"{salary}");
            }



        }

    }
}
