using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxNumberGeneratedPassword = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int A = 35; A <= 55; A++)
            {
                for (int B = 64; B <= 96; B++)
                {
                    for (int x = 1; x <= a; x++)
                    {
                        for (int y = 1; y <= b; y++)
                        {
                            Console.Write($"{Convert.ToChar(A)}{Convert.ToChar(B)}{x}{y}{Convert.ToChar(B)}{Convert.ToChar(A)}|");
                            counter++;
                            A++;
                            B++;
                            if (counter >= maxNumberGeneratedPassword)
                            {
                                return;
                            }

                            else if (A > 55)
                            {
                                A = 35;
                            }

                            else if (B > 96)
                            {
                                B = 64;
                            }

                            else if (x == a && y == b)
                            {
                                return;
                            }

                            else if (counter == maxNumberGeneratedPassword)
                            {
                                
                                Console.Write($"{Convert.ToChar(A)}{Convert.ToChar(B)}{x}{y}{Convert.ToChar(B)}{Convert.ToChar(A)}|");


                            }
                        }
                    }
                }
            }
        }
    }
}
