using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Dating_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> males = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> females = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int matchesCount = 0;

            while (males.Count > 0 && females.Count > 0)
            {
                if (males.Peek() <= 0)
                {
                    males.Pop();
                    continue;
                }

                if (females.Peek() <= 0)
                {
                    females.Dequeue();
                    continue;
                }

                if (males.Peek() % 25 == 0 && males.Peek() != 0)
                {
                    males.Pop();

                    if (males.Any())
                    {
                        males.Pop();
                    }
                    
                    continue;
                }

                if (females.Peek() % 25 == 0 && females.Peek() != 0)
                {
                    females.Dequeue();

                    if (females.Any())
                    {
                    females.Dequeue();
                    }

                    continue;
                }

                if (males.Peek() == females.Peek())
                {
                    matchesCount++;
                    males.Pop();
                    females.Dequeue();
                }
                else
                {
                    females.Dequeue();
                    males.Push(males.Pop() - 2);
                }
            }

            Console.WriteLine($"Matches: {matchesCount}");

            if (males.Count == 0)
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.WriteLine($"Males left: " + string.Join(", ", males));
            }

            if (females.Count == 0)
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: " + string.Join(", ", females));
            }
        }
    }
}
