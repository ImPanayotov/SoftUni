using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int points = 301;
            int succesful = 0;
            int unSuccesful = 0;

            while (points != 0)
            {
                string sector = Console.ReadLine();
                if (sector == "Retire")
                {
                    break;
                }

                int currentPoints = int.Parse(Console.ReadLine());
                if (sector == "Triple")
                {
                    currentPoints *= 3;
                }
                else if (sector == "Double")
                {
                    currentPoints *= 2; 
                }

                points -= currentPoints;
                if (points >= 0)
                {
                    succesful++;
                }
                else
                {
                    unSuccesful++;
                    points += currentPoints;
                }
            }


            if (points == 0)
            {
                Console.WriteLine($"{name} won the leg with {succesful} shots.");
            }
            else
            {
                Console.WriteLine($"{name} retired after {unSuccesful} unsuccessful shots.");
            }
        
        }
    }
}
