using System;
using System.Collections;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    Console.WriteLine($"{counter} cars passed the crossroads.");
                    break;
                }

                if (input == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            counter++;
                        }
                    }

                    continue;
                }

                queue.Enqueue(input);
            }
        }
    }
}
