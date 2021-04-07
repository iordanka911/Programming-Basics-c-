using System;

namespace Plus15Minutes
{
    class Program
    {
        static void Main(string[] arg)

        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 15;
            
            if (minutes > 59)
            {
                minutes -= 60;
                hour += 1;
            }
            if (hour == 24)
            {
                hour = 0;
            }
            if (minutes < 10)
            {
                Console.WriteLine(hour + ":" + "0" + minutes);
            }
            else
            {
                Console.WriteLine($"{ hour}:{minutes}");
            }

        }
    }
}

