using System;

namespace AnimalType
{
    class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            if (gender == "f")
            {
                if (age >= 16) 
                {
                    Console.Write("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                if (age >= 16)
                {
                    Console.Write("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }


        }
    }
}
