using System;

namespace _00._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentDays = int.Parse(Console.ReadLine());
            
            double raisedMoney = 0;
            int dayWon = 0;
            int dayLost = 0;

            for (int day = 1; day <= tournamentDays; day++)
            {
                int wins = 0;
                int loses = 0;
                double currentDayProfit = 0;

                while (true)
                {

                    string input = Console.ReadLine();

                    if (input == "Finish")
                    {
                        break;
                    }
                    if (input == "win")
                    {
                        wins++;
                        currentDayProfit += 20;
                    }
                    else if (input == "lose")
                    {
                        loses++;
                    }
                }
                if (wins > loses)
                {
                    currentDayProfit *= 1.1;
                    dayWon++;
                }
                else
                {
                    dayLost++;
                }
                raisedMoney += currentDayProfit;
            }
            if (dayWon > dayLost)
            {
                raisedMoney *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {raisedMoney:f2}");

            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {raisedMoney:f2}");


            }
        }
    }
}
