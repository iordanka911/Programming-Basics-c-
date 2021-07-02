01. Basketball Equipment
  int feeBasketball = int.Parse(Console.ReadLine());

            double sneakersForBasketball = feeBasketball - 0.40 * feeBasketball;
            double outfitBasketball = sneakersForBasketball - 0.20 * sneakersForBasketball;
            double ballForBasketball = 0.25 * outfitBasketball;
            double accessoariesForBasketball = 0.2 * ballForBasketball;
            double sumcosts = 0;
            sumcosts = feeBasketball + sneakersForBasketball + outfitBasketball + ballForBasketball + accessoariesForBasketball;
            Console.WriteLine($"{sumcosts:f2}");

2.Gymnastics
string country = Console.ReadLine();
            string instrument = Console.ReadLine();
            double difficulty = 0;
            double performance = 0;
            switch (country)
            {
                case "Russia":
                    switch (instrument)
                    {
                        case "ribbon":
                            difficulty = 9.1;
                            performance = 9.4;
                            break;
                        case "hoop":
                            difficulty = 9.3;
                            performance = 9.8;
                            break;
                        case "rope":
                            difficulty = 9.6;
                            performance = 9.0;
                            break;
                    }
                    break;

                case "Bulgaria":
                    switch (instrument)
                    {
                        case "ribbon":
                            difficulty = 9.6;
                            performance = 9.4;
                            break;
                        case "hoop":
                            difficulty = 9.55;
                            performance = 9.75;
                            break;
                        case "rope":
                            difficulty = 9.5;
                            performance = 9.4;
                            break;
                    }
                    break;

                case "Italy":
                    switch (instrument)
                    {
                        case "ribbon":
                            difficulty = 9.2;
                            performance = 9.5;
                            break;
                        case "hoop":
                            difficulty = 9.45;
                            performance = 9.35;
                            break;
                        case "rope":
                            difficulty = 9.7;
                            performance = 9.15;
                            break;
                    }
                    break;
            }
            double finalScore = difficulty + performance;
            double percent = (20 - finalScore) / 20 * 100;

            Console.WriteLine($"The team of {country} get {finalScore:f3} on {instrument}.");
            Console.WriteLine($"{percent:f2}%");

03. Fitness Center
   int numberOfFitnessGuests = int.Parse(Console.ReadLine());
            int numBackActivity = 0;
            int numChestActivity = 0;
            int numLegActivity = 0;
            int numAbsActivity = 0;
            int numOfPeopleForProteinShake = 0;
            int numOfPeopleForProteinBar = 0;
            for (int i = 0; i < numberOfFitnessGuests; i++)
            {
                string activity = Console.ReadLine();
                switch (activity)
                {
                    case "Back":
                        numBackActivity++;
                       
                        break;
                    case "Chest":
                        numChestActivity++;
                        
                        break;
                    case "Legs":
                        numLegActivity++;
                        
                        break;
                    case "Abs":
                        numAbsActivity++;
                        
                        break;
                    case "Protein shake":
                        numOfPeopleForProteinShake++;
                        break;
                    case "Protein bar":
                        numOfPeopleForProteinBar++;
                        break;
                    
                    default:
                        break;
                        
                }
               
            }
            double totalWorkOut = (numAbsActivity + numBackActivity + numChestActivity + numLegActivity) / (numberOfFitnessGuests * 1.0) * 100;
            double totalProtein = (numOfPeopleForProteinBar + numOfPeopleForProteinShake) / (numberOfFitnessGuests * 1.0) * 100;

            Console.WriteLine($"{numBackActivity} - back");
            Console.WriteLine($"{numChestActivity} - chest");
            Console.WriteLine($"{numLegActivity} - legs");
            Console.WriteLine($"{numAbsActivity} - abs");
            Console.WriteLine($"{numOfPeopleForProteinShake} - protein shake");
            Console.WriteLine($"{numOfPeopleForProteinBar} - protein bar");
            Console.WriteLine($"{totalWorkOut:f2}% - work out");
            Console.WriteLine($"{totalProtein:f2}% - protein");

04. High Jump
using System;

namespace HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int desiredHeight = int.Parse(Console.ReadLine());
            int jumpHeight = int.Parse(Console.ReadLine());
            int firstJump = desiredHeight - 30;
            int numJumps = 1;
            int failJumps = 0;

            while (true)
            {

                if (jumpHeight > firstJump)
                {
                    if (firstJump >= desiredHeight)
                    {
                        Console.WriteLine($"Tihomir succeeded, he jumped over {desiredHeight}cm after {numJumps} jumps.");
                        return;
                    }
                    firstJump += 5;
                    failJumps = 0;
                }
                else
                {
                    failJumps++;
                    if (failJumps == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {firstJump}cm after {numJumps} jumps.");
                        return;
                    }
                }
                jumpHeight = int.Parse(Console.ReadLine());
                numJumps++;

            }


        }
    }
}


05. Скелетон
int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            double lenghtInMeters = double.Parse(Console.ReadLine());
            int secondsFor100Meters = int.Parse(Console.ReadLine());

            int timeInSeconds = minutes * 60 + seconds;
            double lostTime = (lenghtInMeters / 120) * 2.5;
            double timePlayer = (lenghtInMeters / 100) * secondsFor100Meters - lostTime;
            if (timeInSeconds>=timePlayer)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timePlayer:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {timePlayer-timeInSeconds:f3} second slower.");
            }

06.Изпитни задачи= Футболни игри
            string team = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());
            int counter = 0;
            int difference = 0;
            int points = 0;
            while (counter<games)
            {
                int scoreGoals = int.Parse(Console.ReadLine());
                int receivedGoals = int.Parse(Console.ReadLine());
                if (scoreGoals>receivedGoals)
                {
                    points += 3;
                }
                else if (scoreGoals==receivedGoals)
                {
                    points++;
                }
               
                difference += scoreGoals - receivedGoals;
                counter++;
            }
            if (difference>=0)
            {
                Console.WriteLine($"{team} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {difference}.");
            }
            else
            {
                Console.WriteLine($"{team} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {difference}.");
            }

07.Товарене на багажи

double trunkCapacity = double.Parse(Console.ReadLine());
            int suitCasesCounter = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine("Congratulations! All suitcases are loaded!");
                    break;
                }
                else
                {
                    double volumeTrunk = double.Parse(input);
                    suitCasesCounter++;

                    if (suitCasesCounter % 3 == 0)
                    {
                        volumeTrunk += volumeTrunk * 0.10;
                    }

                    if (trunkCapacity < volumeTrunk)
                    {
                        suitCasesCounter--;
                        Console.WriteLine("No more space!");
                        break;
                    }

                    trunkCapacity -= volumeTrunk;
                }
            }

            Console.WriteLine($"Statistic: {suitCasesCounter} suitcases loaded.");

08.Дарц турнир

using System;
 
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
 
            string name = Console.ReadLine();
            int startPoints = 301;
            int goodShots = 0;
            int badShots = 0;
            while (startPoints != 0)
            {
 
                string shot = Console.ReadLine();
 
                if (shot == "Retire")
                {
                    Console.WriteLine($"{name} retired after {badShots} unsuccessful shots.");
                    break;
                }
 
                int points = int.Parse(Console.ReadLine());
 
                if (shot == "Single")
 
 
                {
                    if (points <= startPoints && startPoints > 0)
                    {
                        startPoints -= points;
                        goodShots++;
                    }
                    else
                    { 
 
                        badShots++;
                    }
 
                }
 
 
                if (shot == "Double")
                {
                    points *= 2;
                    if (points <= startPoints && startPoints > 0)
                    {
                        startPoints -= points;
                        goodShots++;
                    }
                    else
                    {
 
                        badShots++;
                    }
                }
 
                if (shot == "Triple")
                {
                    points *= 3;
                    if (points <= startPoints && startPoints > 0)
                    {
                        startPoints -= points;
                        goodShots++;
                    }
                    else
                    {
 
                        badShots++;
                    }
                }
 
                if (startPoints == 0)
                {
                    Console.WriteLine($"{name} won the leg with {goodShots} shots.");
                    break;
                }
 
 
            }
 
 
        }
    }
}

09.Коледен Турнир
int numOfDaysTournament = int.Parse(Console.ReadLine());
            double money = 0;
            int daysWon = 0;
            int daysLost = 0;

            for (int i = 1; i <= numOfDaysTournament; i++)
            {
                int gamesWon = 0;
                int gamesLost = 0;
                double dailyMoney = 0;
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input=="Finish")
                    {
                        break;
                    }
                    string result = Console.ReadLine();
                    if (result=="win")
                    {
                        gamesWon++;
                        dailyMoney += 20;
                    }
                    else if (result=="lose")
                    {
                        gamesLost++;
                    }
                }
              
                if (gamesWon > gamesLost)
                {
                        daysWon++;
                        dailyMoney = dailyMoney + dailyMoney * 0.1;
                        money += dailyMoney;
                }
                else
                {
                        daysLost++;
                        money += dailyMoney;
                }
                
               

            }
                   
                if (daysWon>daysLost)
                {
                    double finalSum = money + money * 0.2;
                    Console.WriteLine($"You won the tournament! Total raised money: {finalSum:f2}");
                }
                          
                else
                {
                Console.WriteLine($"You lost the tournament! Total raised money: {money:f2}");
                }



10.Football Results
using System;

namespace FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            int win = 0;
            int loss = 0;
            int drawn = 0;

            for (int game = 1; game <= 3; game++)
            {
                string result = Console.ReadLine();
                char score1 = result[0];
                char score2 = result[2];
                if (score1 > score2)
                {
                    win++;
                }
                else if (score1 < score2)
                {
                    loss++;
                }
                else if (score1 == score2)
                {
                    drawn++;

                }
            }
            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {loss} games.");
            Console.WriteLine($"Drawn games: {drawn}");

        }
    }
}

11.BACK IN THE PAST
using System;

namespace BackInThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());

            double yearsold = 17;

            for (int year = 1800; year <= yearToLive; year++)
            {
                if (year % 2 == 0)
                {
                    heritage = heritage - 12000;
                }
                else if (year % 2 != 0)
                {
                    yearsold += 2;
                    heritage = heritage - (12000 + (50 * yearsold));
                }
            }
            if (heritage >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", heritage);
            }
            else
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(heritage));
            }
        }
    }
}

12.Hospital
using System;

namespace BackInThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int numberOfTreatedPatients = 0;
            int numberOfUntreatedPatients = 0;
            int doctor = 7;
            for (int day = 1; day <= period; day++)
            {
                int numberOfPatients = int.Parse(Console.ReadLine());
                if (day % 3 == 0 && numberOfUntreatedPatients > numberOfTreatedPatients)
                {

                    doctor++;
                }
                
                
                if (numberOfPatients>doctor)
                {
                    numberOfTreatedPatients += doctor;
                    numberOfUntreatedPatients += numberOfPatients - doctor;
                }
                else
                {
                    numberOfTreatedPatients += numberOfPatients;
                }
               
            }
            Console.WriteLine($"Treated patients: {numberOfTreatedPatients}.");
            Console.WriteLine($"Untreated patients: {numberOfUntreatedPatients}.");
        }
          
    }
}

13.Unique PinCodes
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


14. Fitness Card

using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double priceOfTheCard = 0;
            switch(gender)
            {
                case "m":
                    {
                        switch (sport)
                        {
                            case "Gym":
                                priceOfTheCard = 42;
                                break;
                            case "Boxing":
                                priceOfTheCard = 41;
                                break;
                            case "Yoga":
                                priceOfTheCard = 45;
                                break;
                            case "Zumba":
                                priceOfTheCard = 34;
                                break;
                            case "Dances":
                                priceOfTheCard = 51;
                                break;
                            case "Pilates":
                                priceOfTheCard = 39;
                                break;

                        }
                        break;
                    }
                    
                case "f":
                    {
                        switch (sport)
                        {
                            case "Gym":
                                priceOfTheCard = 35;
                                break;
                            case "Boxing":
                                priceOfTheCard = 37;
                                break;
                            case "Yoga":
                                priceOfTheCard = 42;
                                break;
                            case "Zumba":
                                priceOfTheCard = 31;
                                break;
                            case "Dances":
                                priceOfTheCard = 53;
                                break;
                            case "Pilates":
                                priceOfTheCard = 37;
                                break;

                        }
                        break;
                    }
            }
            if (age<=19)
            {
                priceOfTheCard = priceOfTheCard - priceOfTheCard * 0.2;
            }
            if (priceOfTheCard<=budjet)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${priceOfTheCard-budjet:f2} more.");
            }
        }
    }
}
15. Mountain Run

double recordSeconds = double.Parse(Console.ReadLine());
            double spaceMeters = double.Parse(Console.ReadLine());
            double timeSeconds1m = double.Parse(Console.ReadLine());
            double sum = spaceMeters * timeSeconds1m;
            double moreTime= (Math.Floor(spaceMeters / 50) * 30);
            double totalTime = sum + moreTime;
            if (totalTime<recordSeconds)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime-recordSeconds:f2} seconds slower.");
            }    
16.Change bureu
            int numBitcoins = int.Parse(Console.ReadLine());
            double numChinaUana =double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());
            double bitcoinLv = numBitcoins * 1168;
            double ChinaUanaLv = numChinaUana * 0.15 * 1.76;
            double resultEvro = (bitcoinLv + ChinaUanaLv) / 1.95;
            double finalResult = resultEvro - resultEvro * (comision / 100);
            Console.WriteLine($"{finalResult:f2}");
17. Trekking Mania

int numberOfGroupsClimbers = int.Parse(Console.ReadLine());
           
            int numMusala = 0;
            int numMonblan = 0;
            int numKilimandjaro = 0;
            int numK2 = 0;
            int numEverest = 0;

            for (int i = 1; i <= numberOfGroupsClimbers; i++)
            {


                int numOfPeopleInGroup = int.Parse(Console.ReadLine());

                if (numOfPeopleInGroup <= 5)
                    {

                    numMusala += numOfPeopleInGroup; ;
                    }
                    else if (numOfPeopleInGroup >= 6 && numOfPeopleInGroup <= 12)
                    {

                    numMonblan += numOfPeopleInGroup; ;
                    }
                    else if (numOfPeopleInGroup >= 13 && numOfPeopleInGroup <= 25)
                    {
                      
                        numKilimandjaro+=numOfPeopleInGroup;
                    }
                    else if (numOfPeopleInGroup >= 26 && numOfPeopleInGroup <= 40)
                    {
                        
                        numK2+=numOfPeopleInGroup;
                    }
                    else if (numOfPeopleInGroup >= 41)
                    {
                       
                        numEverest+=numOfPeopleInGroup;
                    }
                           
                
               

            }
            double sumOfPeople = numEverest + numK2 + numKilimandjaro + numMonblan + numMusala;
            double percentMusala = (numMusala * 1.0 / sumOfPeople*1.0) * 100;
            double percentMonblan = (numMonblan * 1.0 / sumOfPeople*1.0) * 100;
            double percentKilimangaro = (numKilimandjaro * 1.0 / sumOfPeople*1.0) * 100;
            double percentK2 = (numK2 * 1.0 / sumOfPeople*1.0) * 100;
            double percentEverest = (numEverest * 1.0 / sumOfPeople*1.0) * 100;
            Console.WriteLine($"{percentMusala:f2}%");
            Console.WriteLine($"{percentMonblan:f2}%");
            Console.WriteLine($"{percentKilimangaro:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:f2}%");
18. Movie Day
using System;

namespace MovieDayl
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForRecording = int.Parse(Console.ReadLine());
            int numberOfScenes=int.Parse(Console.ReadLine());
            int timeOfScene = int.Parse(Console.ReadLine());
            double timeFieldOfPreparation = 0.15 * timeForRecording;
            double timeForSceneRecording = (numberOfScenes*timeOfScene)+timeFieldOfPreparation;
            if (timeForSceneRecording<=timeForRecording)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeForRecording-timeForSceneRecording)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(timeForSceneRecording-timeForRecording)} minutes.");
            }
        }
    }
}




19. Великденска екскурзия
using System;

namespace MovieDayl
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string datesForExcursion = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());
            double priceForExcursion = 0;

            switch (destination)
            {
                case "France":
                    if (datesForExcursion == "21-23")
                    {
                        priceForExcursion = numberOfNights * 30;
                    }

                    if (datesForExcursion == "24-27")
                    {
                        priceForExcursion = numberOfNights * 35  ;
                    }

                    if (datesForExcursion == "28-31")
                    {
                        priceForExcursion = numberOfNights * 40;
                    }

                    Console.WriteLine($"Easter trip to {destination} : {priceForExcursion:f2} leva.");
                    break;
                case "Italy":
                    if (datesForExcursion == "21-23")
                    {
                        priceForExcursion = numberOfNights * 28;
                    }

                    if (datesForExcursion == "24-27")
                    {
                        priceForExcursion = numberOfNights * 32;
                    }

                    if (datesForExcursion == "28-31")
                    {
                        priceForExcursion = numberOfNights * 39;
                    }

                    Console.WriteLine($"Easter trip to {destination} : {priceForExcursion:f2} leva.");
                    break;
                case "Germany":
                    if (datesForExcursion == "21-23")
                    {
                        priceForExcursion = numberOfNights * 32;
                    }

                    if (datesForExcursion == "24-27")
                    {
                        priceForExcursion = numberOfNights * 37;
                    }

                    if (datesForExcursion == "28-31")
                    {
                        priceForExcursion = numberOfNights * 43;
                    }

                    Console.WriteLine($"Easter trip to {destination} : {priceForExcursion:f2} leva.");
                    break;
                                      
            }
            
            
                
             
        }
    }
}

int numberOfPaintedEggs = int.Parse(Console.ReadLine());
          
            int numOfRedEggs = 0;
            int numOfBlueEggs = 0;
            int numOfGreenEggs = 0;
            int numOfOrangeEggs = 0;
            int maxNumOfEggs = int.MinValue;
            string maxNumOfEggsColor = String.Empty;

            for (int i = 0; i < numberOfPaintedEggs; i++)
            {
                string colorOfTheEgg = Console.ReadLine();

                switch(colorOfTheEgg)
                {
                    case "red":
                        numOfRedEggs++;
                        if (numOfRedEggs>maxNumOfEggs)
                        {
                            maxNumOfEggs = numOfRedEggs;
                            maxNumOfEggsColor = "red";
                        }
                        break;
                    case "blue":
                        numOfBlueEggs++;
                        if (numOfBlueEggs > maxNumOfEggs)
                        {
                            maxNumOfEggs = numOfBlueEggs;
                            maxNumOfEggsColor = "blue";
                        }
                        break;
                    case "green":
                        numOfGreenEggs++;
                        if (numOfGreenEggs > maxNumOfEggs)
                        {
                            maxNumOfEggs = numOfGreenEggs;
                            maxNumOfEggsColor = "green";
                        }
                        break;
                    case "orange":
                        numOfOrangeEggs++;
                        if (numOfOrangeEggs > maxNumOfEggs)
                        {
                            maxNumOfEggs = numOfOrangeEggs;
                            maxNumOfEggsColor = "orange";
                        }
                        break;
                       
                }
            }

            Console.WriteLine($"Red eggs: {numOfRedEggs}");
            Console.WriteLine($"Orange eggs: {numOfOrangeEggs}");
            Console.WriteLine($"Blue eggs: {numOfBlueEggs}");
            Console.WriteLine($"Green eggs: {numOfGreenEggs}");
            Console.WriteLine($"Max eggs: {maxNumOfEggs} -> {maxNumOfEggsColor}");






   string name = Console.ReadLine();

            int score = 301;

            int successfulshots = 0;
            int unsuccessfulshots = 0;
            string area = Console.ReadLine();

            while (area!="Retire")
            {
                int points = int.Parse(Console.ReadLine());
                int currentPoints = 0;
                if (currentPoints<=0)
                {
                    switch (area)
                    {
                        case "Single":
                            points = currentPoints;
                            successfulshots++;
                        break;
                        case "Double":
                            points = currentPoints * 2;
                            successfulshots++;
                            break;
                        case "Triple":
                            points = currentPoints * 3;

                            successfulshots++;
                            break;
                    }
                }
                else
                {
                    unsuccessfulshots++;
                }
                area = Console.ReadLine();
                if ((score - currentPoints) == 0)
                {
                    Console.WriteLine($"{name} won the leg with {successfulshots} shots.");
                }
                else
                {
                    Console.WriteLine($"{name} retired after {unsuccessfulshots} unsuccessful shots.");
                }
            }



20.Movie profit 
static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int countOfTickets = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double sumFromTickets = countOfTickets * ticketPrice;
            double sumForWholePeriod = sumFromTickets * days;
            double discount = sumForWholePeriod * percent / 100;
            double finalSum = sumForWholePeriod - discount;
            Console.WriteLine($"The profit from the movie {text} is {finalSum:f2} lv.");
        }


21.Lunch break
  string text = Console.ReadLine();
            int durationOfTvSeries = int.Parse(Console.ReadLine());
            int durationOfBrake = int.Parse(Console.ReadLine());

            double timeForLuch = durationOfBrake * 1.0 / 8;
            double timeForBrake = durationOfBrake * 1.0 / 4;
            double timeLeft = durationOfBrake - timeForLuch - timeForBrake;

            if (timeLeft>durationOfTvSeries)
            {
                double time = Math.Ceiling(timeLeft - durationOfTvSeries);
                    Console.WriteLine($"You have enough time to watch {text} and left with {time} minutes free time.");
            }
            else
            {
                double neededTime = Math.Ceiling(durationOfTvSeries - timeLeft);
                Console.WriteLine($"You don't have enough time to watch {text}, you need {neededTime} more minutes.");
            }
            

22.Gymnastics

string country = Console.ReadLine();
            string instrument = Console.ReadLine();
            double difficulty = 0;
            double performance = 0;
             switch (country)
             {
                case "Russia":
                    switch (instrument)
                    {
                        case "ribbon":
                            difficulty = 9.1;
                            performance = 9.4;
                        break;
                        case "hoop":
                            difficulty = 9.3;
                            performance = 9.8;
                            break;
                        case "rope":
                            difficulty = 9.6;
                            performance = 9.0;
                            break;
                    }
                    break;

                case "Bulgaria":
                    switch (instrument)
                    {
                        case "ribbon":
                            difficulty = 9.6;
                            performance = 9.4;
                            break;
                        case "hoop":
                            difficulty = 9.55;
                            performance = 9.75;
                            break;
                        case "rope":
                            difficulty = 9.5;
                            performance = 9.4;
                            break;
                    }
                    break;

                case "Italy":
                    switch (instrument)
                    {
                        case "ribbon":
                            difficulty = 9.2;
                            performance = 9.5;
                            break;
                        case "hoop":
                            difficulty = 9.45;
                            performance = 9.35;
                            break;
                        case "rope":
                            difficulty = 9.7;
                            performance = 9.15;
                            break;
                    }
                    break;
            }
            double finalScore = difficulty + performance;
            double percent = (20 - finalScore) / 20 * 100;

            Console.WriteLine($"The team of {country} get {finalScore:f3} on {instrument}.");
            Console.WriteLine($"{percent:f2} %");
            

23.Movie ratings

int countOfMovies = int.Parse(Console.ReadLine());
            double minRating = double.MaxValue;
            double maxRating = double.MinValue;
            string BESTmOVIE = "";
            string worstMovie = "";
            double sum = 0;
            for (int i = 0; i < countOfMovies; i++)
            {
                string text = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                if (rating>maxRating)
                {
                    maxRating = rating;
                    BESTmOVIE = text;
                }
                if (rating<minRating)
                {
                    minRating = rating;
                    worstMovie = text;
                }
                sum += rating;
            }
            double average = sum / countOfMovies;
            Console.WriteLine($"{BESTmOVIE} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{worstMovie} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {average:f1}");

24.Tourist Shop

   double budjet = double.Parse(Console.ReadLine());

            int count = 0;
            int allProducts = 0;
            double total = 0;
            string text = Console.ReadLine();
            while (text!="Stop")
            {
                double price = double.Parse(Console.ReadLine());
                count++;
                if (count==3)
                {
                    count = 0;
                    price = price / 2;
                }
                if (price+total>budjet)
                {
                    double neededMoney = price + total - budjet;
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need {neededMoney:f2} leva!");
                    break;
                }
                allProducts++;
                total += price;
                text = Console.ReadLine();

            }
            if (text=="Stop")
            {
                Console.WriteLine($"You bought {allProducts} products for {total:f2} leva.");
            }

25.Vet Parking
int days = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            double dayTax = 0;
            double total = 0;
            for (int day = 1; day <= days; day++)
            {
                for (int hours = 1; hours <= hour; hours++)
                {
                    if (day%2==0&&hours%2!=0)
                    {
                        dayTax += 2.5;
                    }
                    else if(day%2!=0&&hours%2==0)
                    {
                        dayTax += 1.25;
                    }
                    else
                    {
                        dayTax += 1;
                    }
                }
                Console.WriteLine($"Day: {day} - {dayTax:f2} leva");
                total += dayTax;
                dayTax = 0;
            }
            Console.WriteLine($"Total: {total:f2} leva");



int numOfClients = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int i = 0; i < numOfClients; i++)
            {
                double currentTotal = 0;
                int countOfItems = 0;
                string purchase = Console.ReadLine();
                while (purchase!="Finish")
                {
                    countOfItems++;
                    if (purchase=="basket")
                    {
                        currentTotal += 1.50;
                            
                    }
                    else if (purchase=="wreath")
                    {
                        currentTotal += 3.80;
                    }
                    else if (purchase=="chocolate bunny")
                    {
                        currentTotal += 7;
                    }
                    purchase = Console.ReadLine();
                }
                if (countOfItems%2==0)
                {
                    currentTotal-= currentTotal * 0.20;
                }
                totalPrice += currentTotal;
                Console.WriteLine($"You purchased {countOfItems} items for {currentTotal:f2} leva.");
            }
            Console.WriteLine($"Average bill per client is: {totalPrice/numOfClients:f2} leva.");


26. Fitness Center

using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFitnessGuests = int.Parse(Console.ReadLine());
            int numBackActivity = 0;
            int numChestActivity = 0;
            int numLegActivity = 0;
            int numAbsActivity = 0;
            int numOfPeopleForProteinShake = 0;
            int numOfPeopleForProteinBar = 0;
            for (int i = 0; i < numberOfFitnessGuests; i++)
            {
                string activity = Console.ReadLine();
                switch (activity)
                {
                    case "Back":
                        numBackActivity++;
                       
                        break;
                    case "Chest":
                        numChestActivity++;
                        
                        break;
                    case "Legs":
                        numLegActivity++;
                        
                        break;
                    case "Abs":
                        numAbsActivity++;
                        
                        break;
                    case "Protein shake":
                        numOfPeopleForProteinShake++;
                        break;
                    case "Protein bar":
                        numOfPeopleForProteinBar++;
                        break;
                    
                    default:
                        break;
                        
                }
               
            }
            double totalWorkOut = (numAbsActivity + numBackActivity + numChestActivity + numLegActivity) / (numberOfFitnessGuests * 1.0) * 100;
            double totalProtein = (numOfPeopleForProteinBar + numOfPeopleForProteinShake) / (numberOfFitnessGuests * 1.0) * 100;

            Console.WriteLine($"{numBackActivity} - back");
            Console.WriteLine($"{numChestActivity} - chest");
            Console.WriteLine($"{numLegActivity} - legs");
            Console.WriteLine($"{numAbsActivity} - abs");
            Console.WriteLine($"{numOfPeopleForProteinShake} - protein shake");
            Console.WriteLine($"{numOfPeopleForProteinBar} - protein bar");
            Console.WriteLine($"{totalWorkOut:f2}% - work out");
            Console.WriteLine($"{totalProtein:f2}% - protein");

        }
    }
}


27. Club


using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            double desiredRevenue = double.Parse(Console.ReadLine());
            double income = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Party!")
                {
                    break;
                }
                int count = int.Parse(Console.ReadLine());
                double currentPrice = input.Length*count;

                if (currentPrice%2!=0)
                {
                    currentPrice *= 0.75;
                }
                income += currentPrice;
                if (income>=desiredRevenue)
                {
                    break;
                }
            }

            if (income>=desiredRevenue)
            {
                Console.WriteLine("Target acquired.");
            }
            else
            {
                double moneyNeeded = desiredRevenue - income;
                Console.WriteLine($"We need {moneyNeeded:f2} leva more.");
            }
            Console.WriteLine($"Club income - {income:f2} leva.");
        }
    }
}

28. Easter Competition

using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOfEasterBread = int.Parse(Console.ReadLine());

            string topChef = "";
            int topGrade = 0;
            for (int i = 0; i < numOfEasterBread; i++)
            {

                string nameOfTheBaker = Console.ReadLine();
                string currentGrade = Console.ReadLine();
                int grades = 0;
                while (currentGrade != "Stop")
                {
                    var grade = int.Parse(currentGrade);
                    grades += grade;

                    currentGrade = Console.ReadLine();
                }
                Console.WriteLine($"{nameOfTheBaker} has {grades} points.");
                if (grades>topGrade)
                {
                    topGrade = grades;
                    topChef = nameOfTheBaker;

                    Console.WriteLine($"{topChef} is the new number 1!");
                }
            }
            Console.WriteLine($"{topChef} won competition with {topGrade} points!");
        }
    }
}

29.Division numbers
   int n = int.Parse(Console.ReadLine());
            int countFirst = 0;
            int countSecond = 0;
            int countThird = 0;
            
            for (int i = 1; i <= n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value%2==0)
                {
                    countFirst++;
                }
                if (value%3==0)
                {
                    countSecond++;
                }
                if (value%4==0)
                {
                    countThird++;
                }
               
            }
            double percent2 = countFirst*1.0 / n * 100;
            double percent3 = countSecond*1.0/ n * 100;
            double percent4 = countThird*1.0 / n * 100;
            Console.WriteLine($"{percent2:f2}");
            Console.WriteLine($"{percent3:f2}");
            Console.WriteLine($"{percent4:f2}");


30.Supplies For School
using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            double detergentForCleaning = double.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());
            double sum = (pens * 5.80) + (markers * 7.20) + (detergentForCleaning * 1.20);
            double finalSum = sum - (sum * percentDiscount * 0.01);
            Console.WriteLine($"{finalSum:f3}");
        }
    }
}

31. Energy Booster
using System;

namespace EnergyBooster
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

32. Food for Pets
using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());
            double foodQuantity = double.Parse(Console.ReadLine());
            double biscuits = 0;
            double sumFoodForDogs = 0;
            double sumForCats = 0;
            for (int day = 1; day <= numDays; day++)
            {
                double foodQuantityDogPerDay = double.Parse(Console.ReadLine());
                double foodQuantityCatPerDay = double.Parse(Console.ReadLine());
                sumFoodForDogs += foodQuantityDogPerDay;
                sumForCats += foodQuantityCatPerDay;
                if (day%3==0)
                {
                   biscuits += 0.1 * (foodQuantityDogPerDay + foodQuantityCatPerDay);
                    
                }
                
            }
            double sumFoodEaten = sumFoodForDogs + sumForCats;
            double percentEatenFood = (sumFoodEaten / foodQuantity) * 100;
            double percentDog = (sumFoodForDogs/sumFoodEaten ) * 100;
            double percentCats = (sumForCats/sumFoodEaten) * 100;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{percentEatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentCats:f2}% eaten from the cat.");

        }
       
    }
}

33. Грижи за кученце
            int foodBoughtInKg = int.Parse(Console.ReadLine());
            int totalFood = 0;
            string input = Console.ReadLine();
            while (input != "Adopted")
            {
                            
                int eatenFood = int.Parse(input);
                totalFood += eatenFood;
                               
                input = Console.ReadLine();

            }

            if (totalFood<=foodBoughtInKg*1000)
            {
                int diff = (foodBoughtInKg * 1000) - totalFood;
                Console.WriteLine($"Food is enough! Leftovers: {diff} grams.");
            }
            else
            {
                int neededFood = totalFood - (foodBoughtInKg * 1000);
                Console.WriteLine($"Food is not enough. You need {neededFood} grams more.");
            }
           
34.Билети за мач  Conditional Statements Advanced - More Exercises
            double budjet = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numPeopleInGroop = int.Parse(Console.ReadLine());
            double priceForTransport = 0;
            double priceForTicket = 0;
            switch (category)
            {
                case "Normal":
                    priceForTicket = 249.99;
                    if (numPeopleInGroop>=1&&numPeopleInGroop<=4)
                    {
                        priceForTransport = 0.75 * budjet;
                    }
                    if (numPeopleInGroop>=5&&numPeopleInGroop<=9)
                    {
                        priceForTransport = 0.6 * budjet;
                    }
                    if (numPeopleInGroop>=10&&numPeopleInGroop<=24)
                    {
                        priceForTransport = 0.5 * budjet;
                    }
                    if (numPeopleInGroop>=25&&numPeopleInGroop<=49)
                    {
                        priceForTransport = 0.4 * budjet;
                    }
                    if (numPeopleInGroop>=50)
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
            if (allTickets<restMoneyForTickets)
            {
               double leftMoney = restMoneyForTickets - allTickets;
                Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
            }
            else
            {
                double neededMoney = allTickets - restMoneyForTickets;
                Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
            }
35.Вело състезание  Conditional Statements Advanced - More Exercises

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
            sumForCharity = sumForParticipationJunior * numJunior*1.0 + sumForParticipationSenior * numSenior*1.0;
            double costs = 0.05 * sumForCharity;
            double restSum = sumForCharity - costs;
            Console.WriteLine($"{restSum:f2}");





36.Магазин за цветя  Conditional Statements Advanced - More Exercises
    int numberOfBoughtChrisantemum = int.Parse(Console.ReadLine());
            int numOfBoughtRoses = int.Parse(Console.ReadLine());
            int numOfBoughtTulips = int.Parse(Console.ReadLine());
            double priceChrisantemum = 0;
            double priceRoses = 0;
            double priceTulips = 0;
            string season = Console.ReadLine();
            string dayHolidayOrWorking = Console.ReadLine();
            if (season=="Spring"||season=="Summer")
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
            if (dayHolidayOrWorking=="Y")
            {
                priceBouquet = priceBouquet + 0.15 * priceBouquet;
            }
            if (season=="Spring"&&numOfBoughtTulips>7)
            {
                priceBouquet = priceBouquet - priceBouquet * 0.05;
            }
            if (season=="Winter"&&numOfBoughtRoses>=10)
            {
                priceBouquet = priceBouquet - priceBouquet * 0.10;
            }
            if ((numberOfBoughtChrisantemum+numOfBoughtRoses+numOfBoughtTulips)>20)
            {
                priceBouquet = priceBouquet - priceBouquet * 0.2;
            }
            double finalPrice = priceBouquet + 2;
            Console.WriteLine($"{finalPrice:F2}");
37. Кола под наем  Conditional Statements Advanced - More Exercises
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

38.Vacation  Conditional Statements Advanced - More Exercises
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
39. Truck Driver  Conditional Statements Advanced - More Exercises
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
40. Ученически лагер- Conditional Statements Advanced - More Exercises


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


41. Точка върху страната на правоъгълник  Conditional Statements Advanced - More Exercises

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

42. Умножение по 2  Conditional Statements Advanced - More Exercises

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

43. Съдомиялна -While-Loop - More Exercises

using System;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBottles = int.Parse(Console.ReadLine());
            int quantityOfDetergent = numBottles * 750;
            string command = "";
            int vessels = 0;
            int counter = 0;
            int numOfDishesWashed = 0;
            int numOfPotsWashed = 0;
            while (true)
            {
                command=Console.ReadLine();
                if (command=="End")
                {
                    break;
                }
                counter++;
                if (counter%3==0)
                {
                    vessels = int.Parse(command);
                    numOfPotsWashed += vessels;
                    quantityOfDetergent -= vessels * 15;

                }
                else
                {
                    vessels = int.Parse(command);
                    numOfDishesWashed += vessels;

                    quantityOfDetergent -= vessels * 5;
                }
                if (quantityOfDetergent<0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(quantityOfDetergent)} ml. more necessary!");
                    return;
                    
                }
            }
            Console.WriteLine("Detergent was enough!");
            Console.WriteLine($"{numOfDishesWashed} dishes and {numOfPotsWashed} pots were washed.");
            Console.WriteLine($"Leftover detergent {quantityOfDetergent} ml.");
        }
    }
}

44. Система за отчет  -While-Loop - More Exercises


using System;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            int expectedSumFromSells = int.Parse(Console.ReadLine());
            string input = "";
            int counter = 0;
            int transactionsWithCard = 0;
            int transactionsCash = 0;
            int cash = 0;
            int card = 0;
            while ((input=Console.ReadLine())!="End"&&cash+card<expectedSumFromSells)
            {
                int itemsPrice = int.Parse(input);
                if (counter++%2==0)
                {
                    if (itemsPrice>100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        transactionsCash++;
                        cash += itemsPrice;
                        Console.WriteLine($"Product sold!");
                    }
                }
                else
                {
                    if (itemsPrice<10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        transactionsWithCard++;
                        card += itemsPrice;
                        Console.WriteLine($"Product sold!");
                    }
                }
            }
            if (input=="End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
            else
            {
                double averageSumCash = cash * 1.0 / transactionsCash;
                double averageSumCard = card * 1.0 / transactionsWithCard;
                Console.WriteLine($"Average CS: {averageSumCash:f2}");
                Console.WriteLine($"Average CC: {averageSumCard:f2}");
            }
        }
    }
}
45. Поток от букви  --While-Loop - More Exercises

using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool nIsAppeared = false;
            bool cIsAppeared = false;
            bool oIsAppeared = false;
            string printLine = "";
            string newWord = "";
            string letter = Console.ReadLine();
            while (letter != "End")
            {
                char currentLetter = letter[0];
                if (char.IsLetter(currentLetter))
                {
                    if (currentLetter == 'n')
                    {
                        if (nIsAppeared)
                        {
                            newWord += letter;
                        }
                        nIsAppeared = true;
                    }
                    else if (currentLetter == 'c')
                    {
                        if (cIsAppeared)
                        {
                            newWord += letter;
                        }
                        cIsAppeared = true;
                    }
                    else if (currentLetter == 'o')
                    {
                        if (oIsAppeared)
                        {
                            newWord += letter;
                        }
                        oIsAppeared = true;
                    }
                    else
                    {
                        newWord += letter;
                    }
                    if (nIsAppeared && oIsAppeared && cIsAppeared)
                    {
                        printLine += $"{newWord} ";
                        newWord = "";
                        nIsAppeared = false;
                        cIsAppeared = false;
                        oIsAppeared = false;
                    }
                }
                letter = Console.ReadLine();
            }
            Console.WriteLine(printLine);
        }
    }
}


46.Подготовка за изпит
using System;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFailedMarkes = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int solvedProblemCounter = 0;
            double gradeSum = 0;
            string lastProblem = "";
            bool isFailed = true;
            while (failedTimes<numberFailedMarkes)
            {
                string problemName = Console.ReadLine();
                if (problemName=="Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade<=4)
                {
                    failedTimes++;
                }
                gradeSum += grade;
                solvedProblemCounter++;
                lastProblem = problemName;

            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedTimes} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeSum/solvedProblemCounter:f2}");
                Console.WriteLine($"Number of problems: {solvedProblemCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}








        


        

        









Drawing Figures with Loops - More Exercises
47. Rectangle of 10 x 10 Stars
using System;

namespace Rectangle10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =10;
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(new String('*', n));
                            
            }
           


        }
    }
}

48. Rectangle of N x N Stars
using System;

namespace Rectangle10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new String('*', n));
                            
            }
           


        }
    }
}

49.Триъгълник от долари

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine(new String('$',i));
            }

50.Квадратна рамка

using System;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("+");
            Console.Write(new String('-', n - 2));
            Console.Write("+");
            Console.WriteLine();
           
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write("|");
                Console.Write(new String('-', n - 2));
                Console.Write("|");
                Console.WriteLine();
            }
            Console.Write("+");
            Console.Write(new String('-', n - 2));
            Console.Write("+");
        }
    }
}


51.Rectangle
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine("**********");
            }
//
            var n = 12;
            for (int i = 0; i <n; i++)
            {
                Console.WriteLine(new string('*',n));
//
            var n = 5;
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j <n; j++)
                {
                    Console.Write(new string("*"));
                }
                Console.WriteLine();
//
            var n =int.Parse(Console.ReadLine());
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j <n; j++)
                {
                    Console.Write(new string("*"));
                }
                Console.WriteLine();
               
            }


//
            var n =int.Parse(Console.ReadLine());
            for (int i = 0; i <n; i++)
            {
                Console.WriteLine("zdrasti");
                for (int col = 0; col <n; col++)
                {
                    Console.Write(new string("-"));
                }
                Console.WriteLine();
//  square with space 
            var n =int.Parse(Console.ReadLine());
            for (int i = 0; i <n; i++)
            {
                //Console.WriteLine("zdrasti");
                for (int col = 0; col <n; col++)
                {
                    Console.Write(new string("* "));
                }
                Console.WriteLine();
               
            }
// Even and Odd Rows Figure 
using System;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            var n =int.Parse(Console.ReadLine());
            for (int i = 0; i <n/2; i++)
            {
                
                for (int col = 0; col <n; col++)
                {
                    Console.Write(new string("-"));
                }
                Console.WriteLine();
                for (int col = 0; col < n; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
               
            }
        }
    }
}
//
using System;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            var n =int.Parse(Console.ReadLine());
            for (int i = 0; i <n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write(new string("-"));
                    }
                }
                else
                {
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
                                           
            }
        }
    }
}


//
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row <n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
//
           var n = int.Parse(Console.ReadLine());
            for (int row = 0; row <n; row++)
            {              
             Console.WriteLine(new string('*',n));               
            }
//
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row <n; row++)
            {
             Console.Write("*");
                for (int col = 0; col < n-1; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                         
            }

//
using System;
using System.Threading;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row <n; row++)
            {
             Console.Write(“Convert.ToChar(3)”);
                Thread.Sleep(500);
                for (int col = 0; col < n-1; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                Thread.Sleep(500);

            }
        }
    }
}



52. Drawing figures
1.1
using System;
using System.Threading;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 13; i++)
            {
                Console.Write( Convert.ToChar(3));
                Thread.Sleep(500);
            }
            Console.WriteLine();
            for (int row = 0; row < 3; row++)
            {
                Console.Write(Convert.ToChar(3));
                Console.Write("Обичам те!");
                Console.Write(Convert.ToChar(3));
                Console.WriteLine();
                Thread.Sleep(500);

            }
            for (int i = 1; i < 13; i++)
            {
                Console.Write( Convert.ToChar(3));
                Thread.Sleep(500);
            }
            Console.WriteLine();
        } 
    }
}



1.2. Sunglasses
using System;
using System.Threading;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('*',n*2));
            Console.Write(new string(' ',n));
            Console.Write(new string('*',n*2));
            Console.WriteLine();

            for (int row = 0; row <n-2; row++)
            {
                Console.Write('*');
                Console.Write(new string('/', (n * 2) - 2));
                Console.Write('*');
                if (row+1==(n-1)/2)
                {
                    Console.Write(new string('|',n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                

                Console.Write('*');
                Console.Write(new string('/', (n * 2) - 2));
                Console.Write('*');
                Console.WriteLine();
                
            }
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', n * 2));
            Console.WriteLine();
        } 
    }
}

1.3.

using System;
using System.Threading;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 1; i <=200; i++)
            {
                counter++;
                Console.WriteLine(counter);
                Console.WriteLine(Convert.ToChar(i));
            }
        } 
    }
}





53. Club
using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double desiredProfit = double.Parse(Console.ReadLine());
            double profit = 0;
            string command = Console.ReadLine();
            while (command!="Party!")
            {
                int numCocktails = int.Parse(Console.ReadLine());
                double priceOfCurrentCocktail = command.Length;
                double priceOfOrder = priceOfCurrentCocktail * numCocktails;
                if (priceOfOrder%2!=0)
                {
                    priceOfOrder -= priceOfOrder * 0.25;
                }
                profit += priceOfOrder;

               
                if (profit>=desiredProfit)
                {
                    Console.WriteLine("Target acquired.");
                    Console.WriteLine($"Club income - {profit:f2} leva.");
                    break;
                }
                command = Console.ReadLine();
             
                if(command=="Party!")
                {
                    Console.WriteLine($"We need {desiredProfit - profit:f2} leva more.");
                    Console.WriteLine($"Club income - {profit:f2} leva.");
                }
            }
        }
    }
}


54.Football results
using System;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheTeam = Console.ReadLine();
            int numMatchs = int.Parse(Console.ReadLine());
            int points = 0;
            int wins = 0;
            int witoutWinner=0;
            int losts = 0;
            int games = 0;
            for (int i = 1; i <=numMatchs; i++)
            {
                string resultFromMatch = Console.ReadLine();
                if (resultFromMatch=="W")
                {
                    points += 3;
                    wins++;
                    games++;
                }

                if (resultFromMatch=="D")
                {
                    points += 1;
                    witoutWinner++;
                    games++;
                }

                if (resultFromMatch=="L")
                {
                    losts++;
                    games++;
                }

            }
            if (games==0)
            {
                Console.WriteLine($"{nameOfTheTeam} hasn't played any games during this season.");
                return;
            }

            double percentWinedGames = (wins*1.0 / games*1.0) * 100;
            Console.WriteLine($"{nameOfTheTeam} has won {points} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {wins}");
            Console.WriteLine($"## D: {witoutWinner}");
            Console.WriteLine($"## L: {losts}");
            Console.WriteLine($"Win rate: {percentWinedGames:F2}%");

        }
    }
}

55. Магазин за компютърни игри
using System;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumSelledGames = int.Parse(Console.ReadLine());
            int numHearstone = 0;
            int numFortnaite = 0;
            int numOverwatch = 0;
            int numOthers = 0;
            
            for (int i = 1; i <=nNumSelledGames; i++)
            {
                string nameOFtheGame = Console.ReadLine();
                if (nameOFtheGame=="Hearthstone")
                {
                    numHearstone++;
                }

                if (nameOFtheGame=="Fornite")
                {
                    numFortnaite++;
                }
                if (nameOFtheGame=="Overwatch")
                {
                    numOverwatch++;
                }
                if(nameOFtheGame!="Hearthstone"&& nameOFtheGame != "Fornite"&& nameOFtheGame != "Overwatch")
                {
                    numOthers++;
                }
            }
            Console.WriteLine($"Hearthstone - {(numHearstone*1.0 / nNumSelledGames*1.0) * 100:f2}%");
            Console.WriteLine($"Fornite - {(numFortnaite*1.0/ nNumSelledGames*1.0) * 100:f2}%");
            Console.WriteLine($"Overwatch - {(numOverwatch*1.0 / nNumSelledGames*1.0) * 100:f2}%");
            Console.WriteLine($"Others - {(numOthers*1.0 / nNumSelledGames*1.0) * 100:f2}%");
        }
    }
}



56. Renovation= Ремонт
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {

            int height = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            double percentNoPainted = int.Parse(Console.ReadLine());
            double allSurface = height * lenght * 4;
            double wallsForPainting = Math.Ceiling(allSurface - (allSurface * (percentNoPainted / 100)));
            string command = Console.ReadLine();
            int totalArea = 0;

            while (true)
            {
               
                if (command != "Tired!")
                {
                    int paintedWall = int.Parse(command);
                    totalArea+=paintedWall;
                    
                    if (totalArea > wallsForPainting)
                    {
                        Console.WriteLine($"All walls are painted and you have {totalArea - wallsForPainting} l paint left!");
                        break;
                        

                    }
                    if (totalArea == wallsForPainting)
                    {
                        Console.WriteLine("All walls are painted! Great job, Pesho!");
                        break;
                        
                    }
                    command = Console.ReadLine();
                }

                else
                {
                    
                    Console.WriteLine($"{Math.Ceiling(wallsForPainting - totalArea)} quadratic m left.");
                    break;
                }
                
            }

        }
    }
}

57. Colored balls
using System;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {
            int NnumBalls = int.Parse(Console.ReadLine());
            int points = 0;
            int numRedBalls = 0;
            int numOrangeBalls = 0;
            int numYellowBalls = 0;
            int numWhiteBalls = 0;
            int numOtherBalls = 0;
            int numDividesblackballs = 0;
           
            for (int i = 1; i <=NnumBalls; i++)
            {
                string colors =Console.ReadLine();
                if (colors=="red")
                {
                    points += 5;
                    numRedBalls++;
                }
                else if (colors == "orange")
                {
                    points += 10;
                    numOrangeBalls++;
                }
                else if (colors == "yellow")
                {
                    points += 15;
                    numYellowBalls++;
                }
                else if (colors == "white")
                {
                    points += 20;
                    numWhiteBalls++;
                }
                else if (colors == "black")
                {
                    points /= 2;
                    numDividesblackballs++;
                }
                else
                {
                    numOtherBalls++;
                }
            }
            Console.WriteLine($"Tottal points: {points}");
            Console.WriteLine($"Points from red balls: {numRedBalls}");
            Console.WriteLine($"Points from orange balls: {numOrangeBalls}");
            Console.WriteLine($"Points from yellow balls: {numYellowBalls}");
            Console.WriteLine($"Points from white balls: {numWhiteBalls}");
            Console.WriteLine($"Other colors picked: {numOtherBalls}");
            Console.WriteLine($"Divides from black balls: {numDividesblackballs}");

        }
    }
}

58. Best Player
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxGoals = Int32.MinValue;
            string bestPlayer = "";
            while (true)
            {
                string player = Console.ReadLine();
                if (player == "END")
                {
                    Console.WriteLine($"{bestPlayer} is the best player!");

                    if (maxGoals >= 3)
                    {
                        Console.WriteLine($"{bestPlayer} has scored {maxGoals} goals and made a hat-trick !!!");
                    }
                    else
                    {
                        Console.WriteLine($"{bestPlayer} has scored {maxGoals} goals.");
                    }

                }
                else
                {
                    int points = int.Parse(Console.ReadLine());
                    {
                        if (points>maxGoals)
                        {
                            bestPlayer = player;
                            maxGoals = points;
                        }
                        if (maxGoals >= 10)
                        {
                            Console.WriteLine($"{bestPlayer} is the best player!");
                            Console.WriteLine($"{bestPlayer} has scored {maxGoals} goals and made a hat-trick !!!");
                            break;
                        }

                    }
                }
                
            }
            
        }
    }
}



59. Easter Eggs Battles

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {

            int numEggsFirstPlayer = int.Parse(Console.ReadLine());
            int numEggsSecondPlayer = int.Parse(Console.ReadLine());
            int numEggsBrokenFirstPlayer = 0;
            int numEggsBrokenSecondPl = 0;
            string command =Console.ReadLine();
            while (command != "End of battle")
            {
                string winner = command;
                if (winner=="one")
                {
                   numEggsBrokenSecondPl++;
                }
                if (winner=="two")
                {
                    numEggsBrokenFirstPlayer++;
                }
                if (numEggsFirstPlayer==numEggsBrokenFirstPlayer)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {numEggsSecondPlayer-numEggsBrokenSecondPl} eggs left");
                    break;
                }
                if (numEggsSecondPlayer==numEggsBrokenSecondPl)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {numEggsFirstPlayer-numEggsBrokenFirstPlayer} eggs left");
                    break;
                }
                command = Console.ReadLine();
            
               
            }
            if (command == "End of battle")
            {
                Console.WriteLine($"Player one has {numEggsFirstPlayer - numEggsBrokenFirstPlayer} eggs left.");
                Console.WriteLine($"Player two has {numEggsSecondPlayer - numEggsBrokenSecondPl} eggs left.");
                return;
            }
                

            

        }


        
    }
}


60.Esater shop

using System;

namespace EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsInShop = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int numBoughtEggs = 0;
            int currentEggs = 0;
            while(command!="Close")
            {
               
                string input = command;
                int numOfEggsToBrBoughtOrFilledInShop = int.Parse(Console.ReadLine());
                if (input=="Buy")
                {
                    numBoughtEggs += numOfEggsToBrBoughtOrFilledInShop;
                    currentEggs = eggsInShop;
                    eggsInShop -= numOfEggsToBrBoughtOrFilledInShop;
                }
                if (eggsInShop<0)
                {
                    Console.WriteLine("Not enough eggs in store!");
                    Console.WriteLine($"You can buy only {Math.Abs(currentEggs)}.");
                    return;
                }

                if(command=="Fill")
                {
                    eggsInShop += numOfEggsToBrBoughtOrFilledInShop;
                }
                command = Console.ReadLine();

                
            }
           
            Console.WriteLine("Store is closed!");
            Console.WriteLine($"{numBoughtEggs} eggs sold.");
        }
    }
}


61. Easter decoration

using System;

namespace EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numClientsInShop = int.Parse(Console.ReadLine());
            double finalSum = 0;
            
            for (int i = 1; i <=numClientsInShop; i++)
            {
                int itemsPurchased = 0;
                double sumItems = 0;
                string command = Console.ReadLine();
                while (command!="Finish")
                {
                    string purchase = command;
                    if (purchase=="basket")
                    {
                        itemsPurchased++;
                        sumItems += 1.50;
                    }
                    if (purchase == "wreath")
                    {
                        itemsPurchased++;
                        sumItems += 3.80;
                    }
                    if (purchase == "chocolate bunny")
                    {
                        itemsPurchased++;
                        sumItems += 7;
                    }
                   
                    command = Console.ReadLine();
                }
                if (itemsPurchased % 2 == 0)
                {
                    sumItems = sumItems - 0.2 * sumItems;
                }
                Console.WriteLine($"You purchased {itemsPurchased} for {sumItems:f2} leva.");
                finalSum += sumItems;

            }
           
           
            Console.WriteLine($"Average bill per client is: {finalSum/numClientsInShop:f2} leva.");
        }
    }
}



62.Most Powerful Word

using System;
using System.Linq;

namespace ConsoleApp62
{
    class Program
    {
        static void Main(string[] args)
        {
            string end ="End of words";
            decimal maxResult = decimal.MinValue;
            string mostPowerfulWord = string.Empty;
            while (true)
            {
                string word = Console.ReadLine();
                if (word == end)
                {
                    break;
                }


                decimal charSum = 0;
                decimal result = 0;
                foreach (var currentChar in word)
                {
                    charSum += currentChar;
                }
                char[] vowels = new[] { 'a', 'A', 'e', 'E', 'u', 'U', 'i', 'I', 'o', 'O' };
                if (vowels.Any(x=>word.StartsWith(x)))
                {
                    result = charSum * word.Length;
                }
                else
                {
                    result = Math.Floor(charSum / word.Length);
                }

                if (result>maxResult)
                {
                    maxResult = result;
                    mostPowerfulWord = word;
                }
            }
            Console.WriteLine($"The most powerful word is {mostPowerfulWord}-{maxResult}");
        }
    }
}





