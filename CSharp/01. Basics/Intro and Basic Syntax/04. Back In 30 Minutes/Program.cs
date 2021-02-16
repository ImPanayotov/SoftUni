using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int minPlus30 = min + 30;
            

            if (hour == 23 && minPlus30 > 59)
            {
                Console.WriteLine($"0:{min - 30:d2}");
            }
            else if (minPlus30 > 59)
            {
                Console.WriteLine($"{hour + 1}:{min - 30:d2}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minPlus30:d2}");
            }
        }
    }
}
