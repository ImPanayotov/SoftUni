using System;

namespace _05.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            int timeInMin = hour * 60 + min;
            int timeInMinAfter15 = timeInMin + 15;

            int hourAfter15 = timeInMinAfter15 / 60;
            int minAfter15 = timeInMinAfter15 % 60;

            if (hourAfter15 == 24)
            {
                hourAfter15 = 0;
            }
            Console.WriteLine($"{hourAfter15}:{minAfter15:D2}");
        }
    }
}
