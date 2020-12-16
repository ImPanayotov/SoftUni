using System;

namespace _06._Basketball_tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTournament = Console.ReadLine();
            int winCounter = 0;
            int loseCounter = 0;
            int totalMatches = 0;
            while (nameOfTournament != "End of tournaments")
            {
                int NumberOfMatches = int.Parse(Console.ReadLine());
                totalMatches += NumberOfMatches;
                for (int i = 1; i <= NumberOfMatches; i++)
                {
                    int myPoints = int.Parse(Console.ReadLine());
                    int enemyPoints = int.Parse(Console.ReadLine());

                    if (myPoints > enemyPoints)
                    {
                        winCounter += 1;
                        int diff = myPoints - enemyPoints;
                        Console.WriteLine($"Game {i} of tournament {nameOfTournament}: win with {diff} points.");

                    }
                    else if (myPoints < enemyPoints)
                    {
                        loseCounter += 1;
                        int diff = enemyPoints - myPoints;
                        Console.WriteLine($"Game {i} of tournament {nameOfTournament}: lost with {diff} points.");

                    }
                }

                nameOfTournament = Console.ReadLine();

            }
            double winPercent = winCounter * 1.00 / totalMatches * 100;
            double losePercent = loseCounter * 1.00 / totalMatches * 100;
            Console.WriteLine($"{winPercent:f2}% matches win");
            Console.WriteLine($"{losePercent:f2}% matches lost");
        }
    }
}
