using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int studentTicket = 0;
            int standardTicket = 0;
            int kidTicket = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Finish")
                {
                    break;
                }
                int freeSpots = int.Parse(Console.ReadLine());
                int currentFreeSpots = freeSpots;
                while (currentFreeSpots>0)
                {

                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    currentFreeSpots--;

                    if (ticketType=="standard")
                    {
                        standardTicket++;
                    }
                    else if (ticketType=="student")
                    {
                        studentTicket++;
                    }
                    else if(ticketType=="kid")
                    {
                        kidTicket++;
                    }
                   
                }
                double freeSopotsPrcent =100-(currentFreeSpots *1.0/ freeSpots*100);
                Console.WriteLine($"{input} - {freeSopotsPrcent:f2}% full.");
            }
            int totalTickets = standardTicket + studentTicket + kidTicket;
            double studentsTickets = studentTicket * 1.0 / totalTickets * 100;
            double standardTickets = standardTicket * 1.0 / totalTickets * 100;
            double kidTickets = kidTicket * 1.0 / totalTickets * 100;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentsTickets:f2}% student tickets.");
            Console.WriteLine($"{standardTickets:f2}% standard tickets.");
            Console.WriteLine($"{ kidTickets:f2}% kids tickets." );
           
        }
    }
}
