using System;

namespace _04._Darts_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPoints = int.Parse(Console.ReadLine());
            int shotsCounter = 0;
            bool wonWithBullseye = false;

            while (startingPoints > 0)
            {
                string sector = Console.ReadLine();
                shotsCounter++;
                if ("bullseye" == sector)
                {
                    wonWithBullseye = true;
                    break;
                }
                int points = int.Parse(Console.ReadLine());

                if ("number section" == sector)
                {
                    startingPoints -= points;
                }
                else if ("double ring" == sector)
                {
                    startingPoints -= (points * 2);
                }
                else if ("triple ring" == sector)
                {
                    startingPoints -= (points * 3);
                }

                if (startingPoints < 0)
                {
                    break;
                }
            }

            if (wonWithBullseye)
            {
                Console.WriteLine($"Congratulations! You won the game with a bullseye in {shotsCounter} moves!");
            }
            else if (startingPoints == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {shotsCounter} moves!");
            }
            else
            {
                Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(startingPoints)}.");
            }





        }
    }
}
