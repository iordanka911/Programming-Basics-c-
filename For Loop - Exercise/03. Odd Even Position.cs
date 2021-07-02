using System;

namespace loops_exercises_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double oddsum = 0;
            double oddmax = double.MinValue;
            double oddmin = double.MaxValue;
            double evensum = 0;
            double evenmax = double.MinValue;
            double evenmin = double.MaxValue;
            for (int i = 1; i <= count;i++)
            {
                double num=double.Parse(Console.ReadLine());
                if(i%2==0)
                {
                    evensum += num;
                    if (evenmax < num)
                    {
                        evenmax = num;
                    }

                    if (evenmin > num)
                    {
                        evenmin = num;
                    }

                }
                else 
                {
                    oddsum += num;
                    if (oddmax<num)
                    {
                        oddmax = num;
                    }   

                    if (oddmin>num)
                    {
                        oddmin = num;
                    }
                }

                
            }

            Console.WriteLine($"OddSum={oddsum:f2},");
            if (oddsum==0)
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddmin:f2},");
                Console.WriteLine($"OddMax={oddmax:f2},");
            }
            Console.WriteLine($"EvenSum={evensum:f2},");
            if (evensum == 0)
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenmin:f2},");
                Console.WriteLine($"EvenMax={evenmax:f2}");
            }


        }

    }
}
