using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string sizeOfSet = Console.ReadLine();
            int numberOfOrderedSets = int.Parse(Console.ReadLine());
            double priceForAllsets = 0;
            switch (fruit)
            {
                case "Watermelon":
                    switch (sizeOfSet)
                    {
                        case "small":
                            priceForAllsets = 2 * 56 * numberOfOrderedSets;
                            break;
                        case "big":
                            priceForAllsets = 5 * 28.70 * numberOfOrderedSets;
                            break;
                        default:
                            break;
                    }
                    break;
                    case "Mango":
                    switch (sizeOfSet)
                    {
                        case "small":
                            priceForAllsets = 2 * 36.66 * numberOfOrderedSets;
                            break;
                        case "big":
                            priceForAllsets = 5 *19.60 * numberOfOrderedSets;
                            break;
                        default:
                            break;
                    }
                    break;
                     case "Pineapple":
                    switch (sizeOfSet)
                    {
                        case "small":
                            priceForAllsets = 2 * 42.10 * numberOfOrderedSets;
                            break;
                        case "big":
                            priceForAllsets = 5 *24.80 * numberOfOrderedSets;
                            break;
                        default:
                            break;
                    }
                    break;
                    case "Raspberry":
                    switch (sizeOfSet)
                    {
                        case "small":
                            priceForAllsets = 2 * 20 * numberOfOrderedSets;
                            break;
                        case "big":
                            priceForAllsets = 5 * 15.20 * numberOfOrderedSets;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            if (priceForAllsets>=400&&priceForAllsets<=1000)
            {
                priceForAllsets = priceForAllsets - priceForAllsets * 0.15;
            }
            if (priceForAllsets >1000)
            {
                priceForAllsets = priceForAllsets - priceForAllsets * 0.50;
            }
            Console.WriteLine($"{priceForAllsets:f2} lv.");
        }
       
    }
}
