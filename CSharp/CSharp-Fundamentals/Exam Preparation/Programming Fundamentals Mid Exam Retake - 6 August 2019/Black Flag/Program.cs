using System;

namespace Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            decimal expectedPlunder = decimal.Parse(Console.ReadLine());
            decimal totalPlunder = 0.0m;

            

            for (int i = 1; i <= days; i++)
            {
                totalPlunder += dailyPlunder;
                if (i % 3 == 0)
                {
                    totalPlunder += dailyPlunder / 2.0m;
                }
                if (i % 5 == 0)
                {
                    totalPlunder -= totalPlunder * 0.3m;
                }
            }

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                decimal percentage = totalPlunder / expectedPlunder * 100m;
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }

        }
    }
}
