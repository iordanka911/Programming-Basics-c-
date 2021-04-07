using System;

namespace record
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double recordInSeconds = double.Parse(Console.ReadLine());
                double distanceMeters = double.Parse(Console.ReadLine());
                double secForMeter = double.Parse(Console.ReadLine());
                double minutes = 0;
                if (minutes == 15)

                {
                    _ = secForMeter
                              / 60;
                    
                }
                double timeSwimming = distanceMeters * secForMeter;

                double plusSeconds = Math.Floor(distanceMeters / 15) * 12.5;

                double theTime = timeSwimming + plusSeconds;
                if (theTime < recordInSeconds)

                {
                            
                 Console.WriteLine($"Yes, he succeeded! The new world " +
                 $"record is {theTime:f2} seconds.");
                }
                else

                {

                    double secondsNeeded = theTime - recordInSeconds;
                    Console.WriteLine($"No, he failed! He was {secondsNeeded:f2} seconds slower.");

                }
                

            }
        }
    }
}
