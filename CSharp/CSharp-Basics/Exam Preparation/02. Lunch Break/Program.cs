using System;

namespace _02._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {

            string title = Console.ReadLine();
            int episodeLength = int.Parse(Console.ReadLine());
            double breakLength = double.Parse(Console.ReadLine());
            double lunchTime = breakLength * 1 / 8;
            //Console.WriteLine(lunchTime);
            double relaxTime = breakLength * 1 / 4;
            //Console.WriteLine(relaxTime);
            double timeLeft = breakLength - lunchTime - relaxTime;
            //Console.WriteLine(timeLeft);
            

            if (timeLeft >= episodeLength)
            {
                Console.WriteLine($"You have enough time to watch {title} and left with {Math.Ceiling(timeLeft - episodeLength)} minutes free time.");
           }
            else
          {
                Console.WriteLine($"You don't have enough time to watch {title}, you need {Math.Ceiling(Math.Abs(episodeLength - timeLeft))} more minutes.");
           }


        






        }
    }
}
