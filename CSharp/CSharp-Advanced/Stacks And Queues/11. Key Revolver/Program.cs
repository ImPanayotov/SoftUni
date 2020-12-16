using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> bulletStack = new Stack<int>(bullets);

            List<int> locks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int intelValue = int.Parse(Console.ReadLine());
            int bulletCounter = 0;

            while (bulletStack.Count != 0 && locks.Count != 0)
            {
                for (int i = 1; i <= gunBarrelSize; i++)
                {
                    if (bulletStack.Count != 0)
                    {
                        if (bulletStack.Peek() <= locks[0])
                        {
                            Console.WriteLine("Bang!");
                            locks.RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("Ping!");
                        }

                        bulletStack.Pop();
                        bulletCounter++;

                        if (i == gunBarrelSize && bulletStack.Count != 0)
                        {
                            Console.WriteLine("Reloading!");
                        }

                        if (locks.Count == 0)
                        {
                            int moneyEarned = intelValue - (bulletPrice * bulletCounter);
                            Console.WriteLine($"{bulletStack.Count} bullets left. Earned ${moneyEarned}");
                            break;
                        }
                        else if (bulletStack.Count == 0)
                        {
                            Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                            break;
                        }
                    }
                }
            }
        }
    }
}
