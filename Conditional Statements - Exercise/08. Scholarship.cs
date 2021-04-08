using System;

namespace scholarship
{
        class Program
        {
            static void Main(string[] args)
            {
                double incomeLv = double.Parse(Console.ReadLine());
                double avgeSuccess = double.Parse(Console.ReadLine());
                double minSellary = double.Parse(Console.ReadLine());
                double scholarshipSuccess = Math.Floor(avgeSuccess * 25);
                double scholarshipSocial = Math.Floor(0.35 * minSellary);
                if (incomeLv >= minSellary && avgeSuccess >= 5.5)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scholarshipSuccess} BGN");
                }
                else if (incomeLv >= minSellary && avgeSuccess < 5.5)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else if (incomeLv < minSellary && avgeSuccess >= 5.5 && scholarshipSocial <= scholarshipSuccess)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scholarshipSuccess} BGN");
                }
                else if (incomeLv < minSellary && avgeSuccess > 4.5)
                {
                    Console.WriteLine($"You get a Social scholarship {scholarshipSocial} BGN");
                }
                else if (incomeLv<minSellary&&avgeSuccess<=4.5)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
        }
}
