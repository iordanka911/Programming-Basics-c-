using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    for (int k = num1; k <= num2; k++)
                    {
                        for (int m = num1; m < i; m++)
                        {
                          
                            if (i % 2 == 0 && m%2!=0&& i > m && (j + k) % 2 == 0)
                            {
                               
                                Console.Write($"{i}{j}{k}{m} ");
                            }
                            if (m%2==0 && i%2 != 0&& i>m&& (j + k) % 2 == 0)
                            {
                                Console.Write($"{i}{j}{k}{m} ");
                            }
                        }
                    }
                }
            }

        }
    }
}
