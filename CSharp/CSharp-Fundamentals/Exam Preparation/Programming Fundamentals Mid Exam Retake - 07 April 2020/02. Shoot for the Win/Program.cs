using System;
using System.Diagnostics;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int count = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                int index = int.Parse(input);

                if (index >= 0 && index < targets.Length)
                {
                    if (targets[index] != -1)
                    {
                        int value = targets[index];
                        targets[index] = -1;

                        for (int i = 0; i < targets.Length; i++)
                        {
                            if (targets[i] != -1 && targets[i] > value)
                            {
                                targets[i] -= value;
                            }
                            else if (targets[i] != -1 && targets[i] <= value)
                            {
                                targets[i] += value;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i] == -1)
                {
                    count++;
                }
            }

            Console.WriteLine($"Shot targets: {count} -> " + string.Join(" ", targets));
        }
    }
}
