using System;

namespace _02.Movie_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            // podgotovka na teren = 15% ot vremeto za snimki
            int timeForShooting = int.Parse(Console.ReadLine());
            int sceneCount = int.Parse(Console.ReadLine());
            double sceneLength = double.Parse(Console.ReadLine());

            double areaPrep = timeForShooting * 0.15;
            double timeForSceneShooting = sceneLength * sceneCount;
            double totalShootingTime = timeForShooting - areaPrep;

            if (totalShootingTime >= timeForSceneShooting)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(totalShootingTime - timeForSceneShooting)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {timeForSceneShooting - totalShootingTime} minutes.");
            }
        }
    }
}
