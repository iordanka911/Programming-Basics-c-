1.Тръби в басейн

using System;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            int volumePool = int.Parse(Console.ReadLine());
            int flowRateOftheFirstPipe = int.Parse(Console.ReadLine());
            int flowRateOfTheSecondPipe = int.Parse(Console.ReadLine());
            double hoursWorkerMissing = double.Parse(Console.ReadLine());

            double litresFirstPipe = flowRateOftheFirstPipe * hoursWorkerMissing;
            double litersSecondPipe = flowRateOfTheSecondPipe * hoursWorkerMissing;
            double sumLitres = litresFirstPipe + litersSecondPipe;
            if (sumLitres<=volumePool)
            {
                double percentFullPool = sumLitres / volumePool*100;
                double percentFirstPipe = litresFirstPipe / sumLitres*100;
                double percentSecondPipe = litersSecondPipe / sumLitres*100;
                Console.WriteLine($"The pool is {percentFullPool:f2}% full. Pipe 1: " +
                    $"{percentFirstPipe:F2}%. Pipe 2: {percentSecondPipe:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {hoursWorkerMissing} hours the pool overflows with {sumLitres-volumePool:f2} liters.");
            }
           



        }
    }
}

2.Поспаливата котка Том


using System;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDaysHoliday = int.Parse(Console.ReadLine());
            double timeForPlayHoliday = numberDaysHoliday * 127;
            double timeForPlayWorkingDays = (365 - numberDaysHoliday) * 63;
            double allTimeForPlay = timeForPlayHoliday + timeForPlayWorkingDays;
            if (allTimeForPlay>30000)
            {
                Console.WriteLine("Tom will run away");
                double diff = allTimeForPlay - 30000;
                double hours = Math.Floor(diff / 60);
                double minutes = diff % 60;
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                double differenceLess = 30000 - allTimeForPlay;
                double hoursLess = Math.Floor(differenceLess / 60);
                double minutesLess = differenceLess % 60;
                Console.WriteLine($"{hoursLess} hours and {minutesLess} minutes less for play");
            }
        }
    }
}

3. Barcode Generator- Баркод Генератор – Вложени цикли 


using System;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            int beggining = int.Parse(Console.ReadLine());
            int endingNumber = int.Parse(Console.ReadLine());
            int firsDigit1 = (beggining/1000)%10;
            int secondDigit1 = (beggining/100)%10;
            int thirdDigit1 = (beggining/10)%10;
            int forthDigit1 = beggining%10;
            int firstDigit2 = (endingNumber/1000)%10;
            int secondDigit2 = (endingNumber/100)%10;
            int thirdDidit2 = (endingNumber/10)%10;
            int forthDigit2 = endingNumber%10;
            for (int i = firsDigit1; i <=firstDigit2; i++)
            {
                for (int j = secondDigit1; j <=secondDigit2; j++)
                {
                    for (int k = thirdDigit1; k <=thirdDidit2; k++)
                    {
                        for (int m = forthDigit1; m <= forthDigit2; m++)
                        {
                            if (i%2!=0&&j%2!=0&&k%2!=0&&m%2!=0)
                            {
                                Console.WriteLine($"{i}{j}{k}{m}");
                            }
                        }
                    }
                }
            }
        }
    }
}
