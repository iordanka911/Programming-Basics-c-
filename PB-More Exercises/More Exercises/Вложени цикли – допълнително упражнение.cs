1.Уникални PIN кодове
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

2.Комбинации от букви

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


3. Щастливи числа
using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <=9; j++)
                {
                    for (int k = 1; k <=9; k++)
                    {
                        for (int l = 1; l <=9; l++)
                        {
                            if (i+j==k+l&&N%(i+j)==0)
                            {
                                
                                Console.Write($"{i}{j}{k}{l} ");

                            }
                            
                            
                        }
                    }
                }  
            }
            


        }
    }
}

4. Номер

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


5.Предизвикай Сватбата

using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMans = int.Parse(Console.ReadLine());
            int numWomens = int.Parse(Console.ReadLine());
            int MaxNumberTabeles = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= numMans; i++)
            {
                for (int j = 1; j <= numWomens; j++)
                {
                    Console.Write($"({i} <-> {j}) ");
                    counter++;
                    if (counter == MaxNumberTabeles)
                    {
                        return;
                    }
                    
                }

            }

        }
    }
}

6.Сватбени места


7.Генератор за сигурни пароли
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
            
            for (int A = 35; A <=55; A++)
            {
                for (int B = 64; B <=96; B++)
                {
                    for (int x = 1; x <=a; x++)
                    {
                        for (int y = 1; y <=b; y++)
                        {
                            Console.WriteLine($"{Convert.ToChar(A)}{Convert.ToChar(B)}{x}{y}{Convert.ToChar(B)}{Convert.ToChar(A)}");
                            counter++;
                            A++;
                            B++;
                            if (counter>=maxNumberGeneratedPassword)
                            {
                                return;                                
                            }        
                                                       
                            else if (A>55)
                            {
                                A = 35;
                            }

                            else if (B>96)
                            {
                                B = 64;
                            }

                            else if (x==a&&y==b)
                            {
                                return;
                            }
                            
                            else if (counter==maxNumberGeneratedPassword)
                            {
                                break;
                                Console.WriteLine($"{Convert.ToChar(A)}{Convert.ToChar(B)}{x}{y}{Convert.ToChar(B)}{Convert.ToChar(A)}");


                            }  
                        }
                    }
                }
            }
        }
    }
}

8. Отключване на тайната врата
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

9.Сума от две числа

using System;

namespace NewTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum= int.Parse(Console.ReadLine());

            int counter = 0;
            bool flag = false;
            for (int num1 = start; num1 <= end; num1++)
            {
                for (int num2 = start; num2 <= end; num2++)
                {
                    counter++;
                    if (num1 + num2 == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({num1} + {num2} = {magicNum})");
                        Environment.Exit(0);
                    }
                }


               
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
        }
    }
}

10. Банкноти и монети

using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCoins1Lv = int.Parse(Console.ReadLine());
            int numCoins2Lv = int.Parse(Console.ReadLine());
            int num5Lv = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            for (int i = 0; i <=numCoins1Lv; i++)
            {
                for (int j = 0; j <=numCoins2Lv; j++)
                {
                    for (int k = 0; k <=num5Lv; k++)
                    {
                        if (sum == i * 1 + j * 2 + k * 5)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                        
                       
                    }
                }
            }
        }
    }
}

11.Паркинг "Happy Cat"
using System;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());
            int numHours = int.Parse(Console.ReadLine());
            double currentSum = default(double);
            double finalPriceForDay = default(double);
           
            for (int days = 1; days <=numDays; days++)
            {
                for (int hours = 1; hours <=numHours;hours++)
                {
                    if (days % 2 == 0 && hours % 2 != 0)
                    {
                        currentSum += 2.50;
                        finalPriceForDay += 2.50;
                    }
                    else if (days % 2 != 0 && hours % 2 == 0)
                    {
                        currentSum += 1.25;
                        finalPriceForDay += 1.25;
                    }
                    else
                    {
                        currentSum += 1.00;
                        finalPriceForDay += 1;
                    }
                    
                   
                }
                Console.WriteLine($"Day: {days} - {currentSum:f2} leva");
                currentSum = 0;
            }
            Console.WriteLine($"Total: {finalPriceForDay} leva");


        }
    }
}


12. Песента на колелетата
using System;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int counter = 0;
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            for (int a = 1; a <=9; a++)
            {
                for (int b = 1; b <=9; b++)
                {
                    for (int c = 1; c <=9; c++)
                    {
                        for (int d = 1; d <=9; d++)
                        {                          
                            if (a<b&&c>d)
                            {
                                if (M == a * b + c * d)
                                {
                                    Console.Write($"{a}{b}{c}{d} ");
                                    counter++;
                                    if (counter == 4)
                                    {
                                        A = a;
                                        B = b;
                                        C = c;
                                        D = d; 
                                    }

                                }
                                            

                            }
                          
                        }
                    }
                }
            }
            if (counter>=4)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"Password: {A}{B}{C}{D}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }

        }
    }
}


13. Четни двойки
using System;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialValueFirstCaple = int.Parse(Console.ReadLine());
            int initialValueSecondCaple = int.Parse(Console.ReadLine());
            int differenceInitAndFinalValueFirstCaple = int.Parse(Console.ReadLine());
            int differenceInitAndFinalValueSecondCaple = int.Parse(Console.ReadLine());

            int maxA = initialValueFirstCaple + differenceInitAndFinalValueFirstCaple;
            int maxB = initialValueSecondCaple + differenceInitAndFinalValueSecondCaple;
            
            for (int i = initialValueFirstCaple; i <=maxA; i++)
            {
                int counterA = 0;
                for (int k = 1; k <=i; k++)
                {
                    if (i%k==0)
                    {
                        counterA++;
                    }
                }
                if (counterA==2)
                {
                    for (int j = initialValueSecondCaple; j <=maxB; j++)
                    {
                        int counterB = 0;
                        for (int l = 1; l <=j; l++)
                        {
                            if (j%l==0)
                            {
                                counterB++;
                            }
                        }
                        if (counterB==2)
                        {
                            Console.WriteLine($"{i}{j}");
                        }
                    }
                }
            }
        }
    }
}

