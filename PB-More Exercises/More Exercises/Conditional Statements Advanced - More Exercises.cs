01. Match Tickets
using System;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numPeopleInGroop = int.Parse(Console.ReadLine());
            double priceForTransport = 0;
            double priceForTicket = 0;
            switch (category)
            {
                case "Normal":
                    priceForTicket = 249.99;
                    if (numPeopleInGroop >= 1 && numPeopleInGroop <= 4)
                    {
                        priceForTransport = 0.75 * budjet;
                    }
                    if (numPeopleInGroop >= 5 && numPeopleInGroop <= 9)
                    {
                        priceForTransport = 0.6 * budjet;
                    }
                    if (numPeopleInGroop >= 10 && numPeopleInGroop <= 24)
                    {
                        priceForTransport = 0.5 * budjet;
                    }
                    if (numPeopleInGroop >= 25 && numPeopleInGroop <= 49)
                    {
                        priceForTransport = 0.4 * budjet;
                    }
                    if (numPeopleInGroop >= 50)
                    {
                        priceForTransport = 0.25 * budjet;
                    }

                    break;

                case "VIP":
                    priceForTicket = 499.99;
                    if (numPeopleInGroop >= 1 && numPeopleInGroop <= 4)
                    {
                        priceForTransport = 0.75 * budjet;
                    }
                    if (numPeopleInGroop >= 5 && numPeopleInGroop <= 9)
                    {
                        priceForTransport = 0.6 * budjet;
                    }
                    if (numPeopleInGroop >= 10 && numPeopleInGroop <= 24)
                    {
                        priceForTransport = 0.5 * budjet;
                    }
                    if (numPeopleInGroop >= 25 && numPeopleInGroop <= 49)
                    {
                        priceForTransport = 0.4 * budjet;
                    }
                    if (numPeopleInGroop >= 50)
                    {
                        priceForTransport = 0.25 * budjet;
                    }

                    break;

            }
            double restMoneyForTickets = budjet - priceForTransport;
            double allTickets = priceForTicket * numPeopleInGroop;
            if (allTickets < restMoneyForTickets)
            {
                double leftMoney = restMoneyForTickets - allTickets;
                Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
            }
            else
            {
                double neededMoney = allTickets - restMoneyForTickets;
                Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
            }



        }
    }
}

02. Bike Race
using System;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            int numJunior = int.Parse(Console.ReadLine());
            int numSenior = int.Parse(Console.ReadLine());
            string typeOfTrace = Console.ReadLine();
            double sumForParticipationJunior = 0;
            double sumForParticipationSenior = 0;
            double sumForCharity = 0;

            switch (typeOfTrace)
            {
                case "trail":
                    sumForParticipationJunior = 5.50;
                    sumForParticipationSenior = 7;
                    break;
                case "cross-country":
                    sumForParticipationJunior = 8;
                    sumForParticipationSenior = 9.50;
                    break;
                case "downhill":
                    sumForParticipationJunior = 12.25;
                    sumForParticipationSenior = 13.75;
                    break;
                case "road":
                    sumForParticipationJunior = 20;
                    sumForParticipationSenior = 21.50;
                    break;
            }

            if (typeOfTrace == "cross-country" && (numJunior + numSenior) >= 50)
            {
                sumForParticipationJunior = sumForParticipationJunior - 0.25 * sumForParticipationJunior;
                sumForParticipationSenior = sumForParticipationSenior - 0.25 * sumForParticipationSenior;
            }
            sumForCharity = sumForParticipationJunior * numJunior * 1.0 + sumForParticipationSenior * numSenior * 1.0;
            double costs = 0.05 * sumForCharity;
            double restSum = sumForCharity - costs;
            Console.WriteLine($"{restSum:f2}");


        }
    }
}


03. Flowers
using System;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBoughtChrisantemum = int.Parse(Console.ReadLine());
            int numOfBoughtRoses = int.Parse(Console.ReadLine());
            int numOfBoughtTulips = int.Parse(Console.ReadLine());
            double priceChrisantemum = 0;
            double priceRoses = 0;
            double priceTulips = 0;
            string season = Console.ReadLine();
            string dayHolidayOrWorking = Console.ReadLine();
            if (season == "Spring" || season == "Summer")
            {
                priceChrisantemum = 2;
                priceRoses = 4.10;
                priceTulips = 2.50;
            }
            if (season == "Autumn" || season == "Winter")
            {
                priceChrisantemum = 3.75;
                priceRoses = 4.50;
                priceTulips = 4.15;
            }
            double priceBouquet = numberOfBoughtChrisantemum * priceChrisantemum + numOfBoughtRoses * priceRoses + numOfBoughtTulips * priceTulips;
            if (dayHolidayOrWorking == "Y")
            {
                priceBouquet = priceBouquet + 0.15 * priceBouquet;
            }
            if (season == "Spring" && numOfBoughtTulips > 7)
            {
                priceBouquet = priceBouquet - priceBouquet * 0.05;
            }
            if (season == "Winter" && numOfBoughtRoses >= 10)
            {
                priceBouquet = priceBouquet - priceBouquet * 0.10;
            }
            if ((numberOfBoughtChrisantemum + numOfBoughtRoses + numOfBoughtTulips) > 20)
            {
                priceBouquet = priceBouquet - priceBouquet * 0.2;
            }
            double finalPrice = priceBouquet + 2;
            Console.WriteLine($"{finalPrice:F2}");

        }
    }
}

04. Car To Go
using System;

namespace carForRent
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string classOfCar = string.Empty;
            double priceForCar = 0;
            string typeOfCar = "";

            if (budjet<=100)
            {
                classOfCar = "Economy class";
                switch (season)
                {
                    case "Summer":
                        typeOfCar = "Cabrio";
                        priceForCar = 0.35 * budjet;
                        break;
                    case "Winter":
                        typeOfCar = "Jeep";
                        priceForCar = 0.65 * budjet;
                        break;
                    default:
                        break;
                }
            }
            if (budjet>100&&budjet<=500)
            {
                classOfCar = "Compact class";
                switch (season)
                {
                    case "Summer":
                        typeOfCar = "Cabrio";
                        priceForCar = 0.45 * budjet;
                        break;
                    case "Winter":
                        typeOfCar = "Jeep";
                        priceForCar = 0.80 * budjet;
                        break;
                    default:
                        break;
                }
            }
            if (budjet >500)
            {
                classOfCar = "Luxury class";
                typeOfCar = "Jeep";
                priceForCar = 0.90 * budjet;                     
            }
            Console.WriteLine($"{classOfCar}");
            Console.WriteLine($"{typeOfCar} - {priceForCar:f2}");
                     
                       
        }
    }
}

05. Vacation
using System;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string placeForRest = "";
            string location = "";
            double price = 0;

            if (budjet<=1000)
            {
                placeForRest = "Camp";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = 0.65 * budjet;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = 0.45 * budjet;
                        break;
                    default:
                        break;
                }
            }
            if (budjet>1000&&budjet<=3000)
            {
                placeForRest = "Hut";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = 0.80 * budjet;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = 0.60 * budjet;
                        break;
                    default:
                        break;
                }
            }
            if (budjet >= 3000)
            {
                placeForRest = "Hotel";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        price = 0.90 * budjet;
                        break;
                    case "Winter":
                        location = "Morocco";
                        price = 0.90 * budjet;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"{location} - {placeForRest} - {price:f2}");
        }
    }
}

06. Truck Driver
using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmForMonth = double.Parse(Console.ReadLine());
            double priceForOneKm = 0;
            double salary = 0;

            if (kmForMonth<=5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        priceForOneKm = 0.75;
                        break;
                    case "Summer":
                        priceForOneKm = 0.90;
                        break;
                    case "Winter":
                        priceForOneKm = 1.05;
                        break;
                    default:
                        break;
                }
            }

            if (kmForMonth>5000&&kmForMonth<=20000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        priceForOneKm = 0.95;
                        break;
                    case "Summer":
                        priceForOneKm = 1.10;
                        break;
                    case "Winter":
                        priceForOneKm = 1.25;
                        break;
                    default:
                        break;
                }
            }
            if (kmForMonth>10000&&kmForMonth<=20000)
            {
                priceForOneKm = 1.45;
            }
            salary = kmForMonth * priceForOneKm * 4;
            double finalSalary = salary - 0.10 * salary;
            Console.WriteLine($"{finalSalary:f2}");

        }
    }
}

07. School Camp
using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int numofStudents = int.Parse(Console.ReadLine());
            int numOfNights = int.Parse(Console.ReadLine());
            double priceForOneNight = 0;
            string sport = "";
            double priceForNights = 0;

            if (season == "Winter")
            {

                if (typeOfGroup == "girls")
                {
                    sport = "Gymnastics";
                    priceForOneNight = 9.60;
                }
                if (typeOfGroup == "boys")
                {
                    sport = "Judo";
                    priceForOneNight = 9.60;
                }
                if (typeOfGroup == "mixed")
                {
                    priceForOneNight = 10.00;
                    sport = "Ski";
                }

            }
            if (season == "Spring")
            {

                if (typeOfGroup == "girls")
                {
                    sport = "Athletics";
                    priceForOneNight = 7.20;
                }
                if (typeOfGroup == "boys")
                {
                    sport = "Tennis";
                    priceForOneNight = 7.20;
                }
                if (typeOfGroup == "mixed")
                {
                    priceForOneNight = 9.50;
                    sport = "Cycling";
                }

            }
            if (season == "Summer")
            {

                if (typeOfGroup == "girls")
                {
                    sport = "Volleyball";
                    priceForOneNight = 15;
                }
                if (typeOfGroup == "boys")
                {
                    sport = "Football";
                    priceForOneNight = 15;
                }
                if (typeOfGroup == "mixed")
                {
                    priceForOneNight = 20;
                    sport = "Swimming";
                }

            }
            priceForNights = numOfNights * priceForOneNight * numofStudents * 1.0;

            if (numofStudents >= 50)
            {
                priceForNights = priceForNights - 0.5 * priceForNights;
            }
            if (numofStudents >= 20 && numofStudents < 50)
            {
                priceForNights = priceForNights - 0.15 * priceForNights;
            }
            if (numofStudents >= 10 && numofStudents < 20)
            {
                priceForNights = priceForNights - 0.05 * priceForNights;
            }
            Console.WriteLine($"{sport} {priceForNights:f2} lv.");
        }
    }
}

////08. Point on Rectangle Border
using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool firstCondition = (x == x1 || x == x2) && (y >= y1 && y <= y2);
            bool secondCondition = (y == y1 || y == y2) && (x >= x1 && x <= x2);

            if (firstCondition||secondCondition)
            {
                Console.WriteLine("Border");
            }
            else
                Console.WriteLine("Inside/Outside");

        }
    }
}

09. Numbers from 1 to 10
using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

10. Multiply by 2
using System;

namespace MultiplicationByTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            double number =0;
            while (true)
            {
                if (number < 0)
                {
                    Console.WriteLine("Negative number!");
                    break;
                }

                else
                {
                    number = double.Parse(Console.ReadLine());
                }

                if (number>=0)
                {
                    Console.WriteLine($"Result: {(number * 2):f2}");
                }

            }         
        }
    }
}
