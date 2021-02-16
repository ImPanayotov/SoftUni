using System;
using System.Collections.Generic;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Queue<int> threads = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));


            int taskValue = int.Parse(Console.ReadLine());

            while (tasks.Count > 0 && threads.Count > 0)
            {
                if (tasks.Peek() == taskValue)
                {
                    Console.WriteLine($"Thread with value {threads.Peek()} killed task {taskValue}");
                    tasks.Pop();
                    break;
                }
                if (threads.Peek() >= tasks.Peek())
                {
                    threads.Dequeue();
                    tasks.Pop();
                    continue;
                }
                else if (threads.Peek() < tasks.Peek())
                {
                    threads.Dequeue();
                    continue;
                }
            }

            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
