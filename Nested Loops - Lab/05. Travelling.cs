using System;

namespace NewTask
{
    class Program
    {
        static void Main(string[] args)
        {

            string destination = Console.ReadLine();
            while (destination!="End")
            {
                double budjet=double.Parse(Console.ReadLine());
                double savedMoney = 0;
                while (savedMoney<budjet)
                {
                    savedMoney += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
      
