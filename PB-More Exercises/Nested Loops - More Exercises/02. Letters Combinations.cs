using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());
            int counter=0;
           
            for (char firstDigit = firstLetter; firstDigit <= secondLetter; firstDigit++)
            {
                for (char secondDigit = firstLetter; secondDigit <= secondLetter; secondDigit++)
                {
                    for (char thirdDigit = firstLetter; thirdDigit <= secondLetter; thirdDigit++)
                    {
                        
                        if (firstDigit!=thirdLetter&&secondDigit!=thirdLetter&&thirdDigit!=thirdLetter)
                        {
                           
                            Console.Write($"{firstDigit}{secondDigit}{thirdDigit} ");

                            counter++;
                        }
                         
                    }
                }

            }
            Console.WriteLine( counter);
            
        }
    }
}
