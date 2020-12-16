using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            int n = int.Parse(Console.ReadLine());

            Stack<int> mins = new Stack<int>();
            mins.Push(int.MaxValue);

            Stack<int> maxs = new Stack<int>();
            maxs.Push(int.MinValue);

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmd[0];

                if (cmdType == "1")
                {
                    int elToPush = int.Parse(cmd[1]);

                    numbers.Push(elToPush);

                    if (elToPush > maxs.Peek())
                    {
                        maxs.Push(elToPush);
                    }

                    if (elToPush < mins.Peek())
                    {
                        mins.Push(elToPush);
                    }
                }
                else if (cmdType == "2")
                {
                    if (numbers.Any())
                    {
                        int el = numbers.Pop();

                        if (maxs.Peek() == el)
                        {
                            maxs.Pop();
                        }

                        if (mins.Peek() == el)
                        {
                            mins.Pop();
                        }
                    }
                }
                else if (cmdType == "3")
                {
                    if (numbers.Any())
                    {
                        Console.WriteLine(maxs.Peek());
                    }
                }
                else if (cmdType == "4")
                {
                    if (numbers.Any())
                    {
                        Console.WriteLine(mins.Peek());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
