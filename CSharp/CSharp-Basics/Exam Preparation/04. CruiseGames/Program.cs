using System;

namespace _04._CruiseGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int volleyballGames = 0;
            int tennisGames = 0;
            int badmintonGames = 0;

            double volleyballPoints = 0;
            double tennisPoints = 0;
            double badmintonPoints = 0;

            string player = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());

            for (int i = 0; i < games; i++)
            {
                string gameName = Console.ReadLine();
                int points = int.Parse(Console.ReadLine());

                switch (gameName)
                {
                    case "volleyball":
                        volleyballPoints += points * 1.07;
                        volleyballGames++;
                        break;
                    case "tennis":
                        tennisPoints += points * 1.05;
                        tennisGames++;
                        break;
                    case "badminton":
                        badmintonPoints += points * 1.02;
                        badmintonGames++;
                        break;
                }
            }

            double volleyballAvgPoints = Math.Floor(volleyballPoints / volleyballGames);
            double tennisAvgPoints = Math.Floor(tennisPoints / tennisGames);
            double badmintonAvgPoints = Math.Floor(badmintonPoints / badmintonGames);
            double totalPoints = Math.Floor(volleyballPoints + tennisPoints + badmintonPoints);

            if (volleyballAvgPoints >= 75 && tennisAvgPoints >= 75 && badmintonAvgPoints >= 75)
            {
                Console.WriteLine($"Congratulations, {player}! You won the cruise games with {totalPoints} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {player}, you lost. Your points are only {totalPoints}.");
            }











        }
    }
}
