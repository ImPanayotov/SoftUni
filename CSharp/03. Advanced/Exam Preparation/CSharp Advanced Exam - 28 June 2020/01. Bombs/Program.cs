using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEffect = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Stack<int> bombCasing = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int datura = 0;
            int cherry = 0;
            int smoke = 0;

            while (bombEffect.Count > 0 && bombCasing.Count > 0)
            {
                int sum = bombEffect.Peek() + bombCasing.Peek();

                if (sum == 40)
                {
                    datura++;
                    bombEffect.Dequeue();
                    bombCasing.Pop();
                }
                else if (sum == 60)
                {
                    cherry++;
                    bombEffect.Dequeue();
                    bombCasing.Pop();
                }
                else if (sum == 120)
                {
                    smoke++;
                    bombEffect.Dequeue();
                    bombCasing.Pop();
                }
                else if (sum != 40 && sum != 60 && sum != 120)
                {
                    bombCasing.Push(bombCasing.Pop() - 5);
                    continue;
                }

                if (datura >= 3 && cherry >= 3 && smoke >= 3)
                {
                    Console.WriteLine($"Bene! You have successfully filled the bomb pouch!");
                    break;
                }
            }

            if (!(datura >= 3 && cherry >= 3 && smoke >= 3))
            {
                Console.WriteLine($"You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffect.Count == 0)
            {
                Console.WriteLine($"Bomb Effects: empty");
            }
            else
            {
                Console.Write("Bomb Effects: ");
                Console.WriteLine(string.Join(", ", bombEffect));
            }

            if (bombCasing.Count == 0)
            {
                Console.WriteLine($"Bomb Casings: empty");
            }
            else
            {
                Console.Write("Bomb Casings: ");
                Console.WriteLine(string.Join(", ", bombCasing));
            }

            Console.WriteLine($"Cherry Bombs: {cherry}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smoke}");
        }
    }
}

