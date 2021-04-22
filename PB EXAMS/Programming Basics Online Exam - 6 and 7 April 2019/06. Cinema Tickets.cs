using System;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheFilm = Console.ReadLine();
           
           
            double numStudentTickets = 0;
            double numKidTickets = 0;
            double numStandardTickets = 0;
            
            while (nameOfTheFilm!="Finish")
            {
               
                int freeSpaceForFilm = int.Parse(Console.ReadLine());
                double busyPlacesForFilm = 0;
                for (int i = 1; i <= freeSpaceForFilm; i++)
                {
                    string typeOfTheTicket = Console.ReadLine();
                    if (typeOfTheTicket == "End")
                    {
                        break;
                    }
                    else if(typeOfTheTicket=="student")
                    {
                        numStudentTickets++;
                    }
                    else if (typeOfTheTicket=="standard")
                    {
                        numStandardTickets++;
                    }
                    else if (typeOfTheTicket=="kid")
                    {
                        numKidTickets++;
                    }
                    busyPlacesForFilm++;
              
                    
                    

                }
                Console.WriteLine($"{nameOfTheFilm} - {(busyPlacesForFilm/freeSpaceForFilm)*100:f2}% full.");



                nameOfTheFilm = Console.ReadLine();

            }
            double totalTickets = numKidTickets + numStandardTickets + numStudentTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(numStudentTickets/totalTickets)*100:f2}% student tickets.");
            Console.WriteLine($"{(numStandardTickets / totalTickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(numKidTickets / totalTickets) * 100:f2}% kids tickets.");

        }
    }
}
