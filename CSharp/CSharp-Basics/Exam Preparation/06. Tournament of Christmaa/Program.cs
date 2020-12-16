using System;

namespace _06._Tournament_of_Christmaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDays = int.Parse(Console.ReadLine());
            
            double moneyWin = 20;
            
            double totalMoney = 0;
            int totalwins = 0;
            int totallose = 0;


            
            
                for (int i = 1; i <= numOfDays; i++)
                {
                int lose = 0;
                int win = 0;
                string sport = Console.ReadLine();
                
                    while (sport != "Finish")
                    {
                    if (sport == "Finish")
                    {
                        break;
                    }
                    string winLose = Console.ReadLine();
                        if (winLose == "Win")
                        {
                        totalwins++;
                            totalMoney += moneyWin;
                        }
                        else if (winLose == "Lose")
                        {
                        totallose++;
                        }
                    }
                }
            Console.WriteLine(totallose);
            Console.WriteLine(totalwins);
            
                //if (win > lose)
                //{
                //    Console.WriteLine($"You won the tournament! Total raised money: {win * moneyWin}");
                //}
                //else if (lose < win)
                //{
                //    Console.WriteLine($"You lost the tournament! Total raised money: {win * moneyWin}");
                //}
            





        }
    }
}
