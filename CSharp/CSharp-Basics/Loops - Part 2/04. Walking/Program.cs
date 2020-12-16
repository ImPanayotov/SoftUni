using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 10000;
            int sumOfSteps = 0;
            int lastSteps = 0;
            string lastStepsOrGoingHome = Console.ReadLine();

            while (true)
            {
                if (lastStepsOrGoingHome == "Going home")
                {
                    lastSteps = int.Parse(Console.ReadLine());
                    sumOfSteps += lastSteps;

                    if (sumOfSteps < steps)
                    {
                        int diff = steps - sumOfSteps;
                        Console.WriteLine($"{diff} more steps to reach goal.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                }

                lastSteps = int.Parse(lastStepsOrGoingHome);
                sumOfSteps += lastSteps;

                if (sumOfSteps >= steps)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }

                lastStepsOrGoingHome = Console.ReadLine();
            }
        }
    }
}
