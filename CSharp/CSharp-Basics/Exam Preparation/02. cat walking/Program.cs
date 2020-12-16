using System;

namespace _02._cat_walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalking = int.Parse(Console.ReadLine());
            int countWalking = int.Parse(Console.ReadLine());
            int callories = int.Parse(Console.ReadLine());

            long allMinutesWalking = countWalking * minutesWalking;
            long allCalloriesBurn = allMinutesWalking * 5;

            if (allCalloriesBurn >= (callories * 0.5))
            {
                Console.WriteLine("Yes, the walk for your cat is enough. Burned calories per day: {0}.", allCalloriesBurn);
            }
            else if (allCalloriesBurn < (callories * 0.5))
            {
                Console.WriteLine("No, the walk for your cat is not enough. Burned calories per day: {0}.", allCalloriesBurn);
            }
        }
    }
}
