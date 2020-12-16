using System;

namespace _01.SumSecondsEX
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTimeInSeconds = firstTime + secondTime + thirdTime;

            double totalTimeInMin = totalTimeInSeconds / 60;
            double totalTimeSecLeft = totalTimeInSeconds % 60;

            if (totalTimeSecLeft >= 10)
            {
                Console.WriteLine(totalTimeInMin + ":" + totalTimeSecLeft);
            }
            else
            {
                Console.WriteLine($"{totalTimeInMin}:0{totalTimeSecLeft}");
            }
            
            
            
            
        }
    }
}
