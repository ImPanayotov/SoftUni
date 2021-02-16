using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                List<string> input = Console.ReadLine()
                    .Split()
                    .ToList();

                if (input[0] == "end")
                {
                    break;
                }

                if (input[0] == "Add")
                {
                    int newWagon = int.Parse(input[1]);
                    wagons.Add(newWagon);
                }
                else
                {
                    int passengers = int.Parse(input[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacity)
                        {
                            wagons[i] = wagons[i] + passengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
