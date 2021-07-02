using System;

namespace scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minutesArrive = int.Parse(Console.ReadLine());
            int examInMinutes = hourExam * 60 + minutesExam;
            int arriveInMinutes = hourArrive * 60 + minutesArrive;
            if (arriveInMinutes>examInMinutes)
            {
                Console.WriteLine("Late");
                int lateInMinutes = arriveInMinutes - examInMinutes;
                if (lateInMinutes<60)
                {
                    Console.WriteLine($"{lateInMinutes} minutes after the start");
                }
                else
                {
                    int lateHours = lateInMinutes / 60;
                    int lateMinutes = lateInMinutes % 60;
                    Console.WriteLine($"{lateHours}:{lateMinutes:D2} hours after the start");
                }
            }
            else if (arriveInMinutes==examInMinutes||examInMinutes-arriveInMinutes<=30)
            {
                Console.WriteLine("On time");
                if (arriveInMinutes!=examInMinutes)
                {
                    Console.WriteLine($"{examInMinutes-arriveInMinutes} minutes before the start");
                }
            }
            else if (examInMinutes-arriveInMinutes>30)
            {
                Console.WriteLine("Early");
                int earlierInMinutes = examInMinutes - arriveInMinutes;
                if (earlierInMinutes<60)
                {
                    Console.WriteLine($"{earlierInMinutes} minutes before the start");
                }
                else
                {
                    int earlierHour = earlierInMinutes / 60;
                    int earlyMinutes = earlierInMinutes % 60;
                    Console.WriteLine($"{earlierHour}:{earlyMinutes:D2} hours before the start");
                }
            }




        }
    }
}
