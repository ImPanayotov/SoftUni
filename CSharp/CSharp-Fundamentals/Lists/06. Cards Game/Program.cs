using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> deck2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            while (true)
            {
                if (deck1.Count == 0 || deck2.Count == 0)
                {
                    break;
                }
                if (deck1[0] > deck2[0])
                {
                    deck1.Add(deck1[0]);
                    deck1.Add(deck2[0]);
                    deck2.RemoveAt(0);
                    deck1.RemoveAt(0);
                }
                else if (deck1[0] == deck2[0])
                {
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                }
                else
                {
                    deck2.Add(deck2[0]);
                    deck2.Add(deck1[0]);
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                }
            }

            if (deck1.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {deck2.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {deck1.Sum()}");
            }
        }
    }
}
