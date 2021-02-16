using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ")
                .ToArray();

            Queue<string> playlist = new Queue<string>(input);

            while (playlist.Count > 0)
            {
                string command = Console.ReadLine();

                if (command.Contains("Play"))
                {
                    playlist.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    int length = command.Length;
                    string song = command.Substring(4, length - 4);

                    if (!playlist.Contains(song))
                    {
                        playlist.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", playlist));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
