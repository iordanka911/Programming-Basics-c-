using System;

namespace UniquePinCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperBorderFirstNumber = int.Parse(Console.ReadLine());
            int upperBorderSecondNumber = int.Parse(Console.ReadLine());
            int upperBorderThirdNumber = int.Parse(Console.ReadLine());
            for (int firstDigit = 2; firstDigit <= upperBorderFirstNumber; firstDigit+=2)
            {
               
                for (int secondDigit = 2; secondDigit <= upperBorderSecondNumber; secondDigit++)
                {
                   
                    for (int thirdDigit = 2; thirdDigit <= upperBorderThirdNumber; thirdDigit+=2)
                    {
                            if (secondDigit == 2 || secondDigit == 3 || secondDigit == 5 || secondDigit == 7)
                            {
                                Console.WriteLine($"{firstDigit} {secondDigit} {thirdDigit}");
                            }
                                
                        

                    }
                }
            


             }
          
        }
    }
}
