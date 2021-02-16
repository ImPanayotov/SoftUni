using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int qty = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max()); // biggest order

            while (queue.Count > 0)
            {
                if (queue.Peek() > qty)
                {
                    Console.WriteLine($"Orders left: " + string.Join(" ", queue));
                    return;
                }

                qty -= queue.Dequeue();
            }

            Console.WriteLine("Orders complete");
        }
    }
}
