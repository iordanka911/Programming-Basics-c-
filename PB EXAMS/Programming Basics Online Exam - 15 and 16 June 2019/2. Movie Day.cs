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
