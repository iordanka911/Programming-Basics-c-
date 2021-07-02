using System;

namespace Number1Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char opperation = char.Parse(Console.ReadLine());
            switch (opperation)
            {
                case '+':
                    int sum = N1 + N2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{N1} {opperation} {N2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {opperation} {N2} = {sum} - odd");
                    }
                    break;
                case '-':
                    int diff = N1 - N2;
                    if (diff % 2 == 0)
                    {
                        Console.WriteLine($"{N1} {opperation} {N2} = {diff} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {opperation} {N2} = {diff} - odd");
                    }
                    break;
                case '*':
                    int multiplication = N1 * N2;
                    if (multiplication % 2 == 0)
                    {
                        Console.WriteLine($"{N1} {opperation} {N2} = {multiplication} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} {opperation} {N2} = {multiplication} - odd");
                    }
                    break;
                case '/':
                    if (N2 == 0)

                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    { 
                    double division = N1*1.0 / N2;
                    Console.WriteLine($"{N1} {opperation} {N2} = {division:f2}");
                    }
                    break;
                case '%':
                    if (N2 == 0)
                    
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    { 
                    int leftOver = N1 % N2;
                    Console.WriteLine($"{N1} {opperation} {N2} = {leftOver}");
                    }
                    break;


            }
        }
    }
}
