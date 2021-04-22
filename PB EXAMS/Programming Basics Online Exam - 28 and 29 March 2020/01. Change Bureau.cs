using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBitcoins = int.Parse(Console.ReadLine());
            double numChinaUana = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());
            double bitcoinLv = numBitcoins * 1168;
            double ChinaUanaLv = numChinaUana * 0.15 * 1.76;
            double resultEvro = (bitcoinLv + ChinaUanaLv) / 1.95;
            double finalResult = resultEvro - resultEvro * (comision / 100);
            Console.WriteLine($"{finalResult:f2}");



        }
    }
}
