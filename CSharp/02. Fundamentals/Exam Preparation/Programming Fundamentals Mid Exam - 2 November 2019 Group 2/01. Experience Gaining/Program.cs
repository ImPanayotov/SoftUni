using System;

namespace _01._Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededXP = double.Parse(Console.ReadLine());
            int battleCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= battleCount; i++)
            {
                double earnedXP = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    neededXP -= earnedXP * 1.15;
                    if (neededXP <= 0)
                    {
                        Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                        return;
                    }
                }
                else if (i % 5 == 0)
                {
                    neededXP -= earnedXP * 0.9;
                    if (neededXP <= 0)
                    {
                        Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                        return;
                    }
                }
                else
                {
                    neededXP -= earnedXP;
                    if (neededXP <= 0)
                    {
                        Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                        return;
                    }
                }
            }

            Console.WriteLine($"Player was not able to collect the needed experience, {neededXP:f2} more needed.");
        }
    }
}
