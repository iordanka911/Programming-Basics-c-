using System;

namespace Number1toN3
{

    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            int toyConter = 0;
            double savedMoney = 0;
            double moneyPresent = 10;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += moneyPresent;
                    savedMoney--;
                    moneyPresent += 10;
                }
                else
                {
                    toyConter++;
                }
            }
            double moneyFromToys = toyConter * toyPrice;
            savedMoney += moneyFromToys;
            if (savedMoney>=washingMachinePrice)
            {
                Console.WriteLine($"Yes! {savedMoney - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - savedMoney:f2}");
            }
              
                           
        }
    }


}
