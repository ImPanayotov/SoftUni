using System;

namespace _08._Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalCal = 0;

            for (int i = 0; i < n; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                
                

                switch (ingredient)
                {
                    case "cheese":
                        totalCal += 500;
                        break;
                    case "tomato sauce":
                        totalCal += 150;
                        break;
                    case "salami":
                        totalCal += 600;
                        break;
                    case "pepper":
                        totalCal += 50;
                        break;
                }
                
            }
            Console.WriteLine($"Total calories: {totalCal}");
        }
    }
}
