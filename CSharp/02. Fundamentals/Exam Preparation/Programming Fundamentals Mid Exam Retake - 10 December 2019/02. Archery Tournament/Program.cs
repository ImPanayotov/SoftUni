using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _02._Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] targets = Console.ReadLine()
                .Split("|")
                .Select(int.Parse)
                .ToArray();

            int points = 0;

            while (true)
            {
                string[] input = Console.ReadLine().Split("@").ToArray();

                string command = input[0];

                if (command == "Game over")
                {
                    break;
                }

                if (command == "Shoot Left")
                {
                    int startIndex = int.Parse(input[1]);
                    int lenght = int.Parse(input[2]);

                    if (startIndex >= 0 && startIndex <= targets.Length - 1)
                    {
                        int left = startIndex - lenght;

                        while (left < 0)
                        {
                            left = targets.Length + left;
                        }
                        if (targets[left] >= 5)
                        {
                            targets[left] -= 5;
                            points += 5;
                        }
                        else
                        {
                            points += targets[left];
                            targets[left] = 0;
                        }
                    }
                }
                else if (command == "Shoot Right")
                {
                    int startIndex = int.Parse(input[1]);
                    int lenght = int.Parse(input[2]);

                    if (startIndex >= 0 && startIndex <= targets.Length - 1)
                    {
                        int right = startIndex + lenght;

                        while (right >= targets.Length)
                        {
                            right = right - targets.Length;
                        }
                        if (targets[right] >= 5)
                        {
                            targets[right] -= 5;
                            points += 5;
                        }
                        else
                        {
                            points += targets[right];
                            targets[right] = 0;
                        }
                    }
                }
                else if (command == "Reverse")
                {
                    Array.Reverse(targets);
                }
            }

            Console.WriteLine(string.Join(" - ", targets));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }


    }
}
