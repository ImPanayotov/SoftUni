using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fire = Console.ReadLine()
                .Split("#")
                .ToArray();
            int water = int.Parse(Console.ReadLine());
            double effort = 0.0;
            List<int> puttedOut = new List<int>();

            for (int i = 0; i < fire.Length; i++)
            {
                string[] cell = fire[i].Split(" = ", StringSplitOptions.RemoveEmptyEntries);
                string type = cell[0];
                int value = int.Parse(cell[1]);

                if (type == "High")
                {
                    if (value >= 81 && value <= 125)
                    {
                        if (water >= value)
                        {
                            water -= value;
                            puttedOut.Add(value);
                            effort += value / 4.0;
                            value = 0;
                        }
                    }
                }
                else if (type == "Medium")
                {
                    if (value >= 51 && value <= 80)
                    {
                        if (water >= value)
                        {
                            water -= value;
                            puttedOut.Add(value);
                            effort += value / 4.0;
                            value = 0;
                        }
                    }
                }
                else if (type == "Low")
                {
                    if (value >= 1 && value <= 50)
                    {
                        if (water >= value)
                        {
                            water -= value;
                            puttedOut.Add(value);
                            effort += value / 4.0;
                            value = 0;
                        }
                    }
                }


            }
            Console.WriteLine("Cells:");
            foreach (var cell in puttedOut)
            {
                Console.WriteLine($"- {cell}");
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: " + puttedOut.Sum());
        }
    }
}
