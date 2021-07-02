using System;

namespace ConsoleApp87
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int firstDigitStart = firstNumber / 1000;
            int secondDigitStart = (firstNumber / 100)%10;
            int thirdDigitStart = (firstNumber / 10) % 10;
            int forthDigitStart = (firstNumber % 10);

            int firstDigitEnd = secondNumber / 1000;
            int secondDigitEnd = (secondNumber / 100) % 10;
            int thirdDigitEnd = (secondNumber / 10) % 10;
            int forthDigitEnd = (secondNumber % 10);

            for (int num1 = firstDigitStart; num1 <=firstDigitEnd; num1++)
            {
                for (int num2 = secondDigitStart; num2 <=secondDigitEnd; num2++)
                {
                    for (int num3 = thirdDigitStart; num3 <=thirdDigitEnd ; num3++)
                    {
                        for (int num4 = forthDigitStart; num4 <=forthDigitEnd; num4++)
                        {
                            if (num1%2!=0&&num2%2!=0&&num3%2!=0&&num4%2!=0)
                            {
                                Console.Write($"{num1}{num2}{num3}{num4} ");
                            }
                        }
                    }
                }
            }
            
        }
    }
}
