using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wins = 0;
            int count = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End of battle")
                {
                    Console.WriteLine($"Won battles: {count}. Energy left: {energy}");
                    break;
                }
                count++;
                int distance = int.Parse(input);

                if (distance <= energy)
                {
                    energy -= distance;
                    wins++;
                    if (count % 3 == 0)
                    {
                        energy += wins;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    return;
                }
            }
        }
    }
}
