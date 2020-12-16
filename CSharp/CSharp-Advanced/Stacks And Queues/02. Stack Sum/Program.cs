using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                stack.Push(nums[i]);
            }

            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split().ToArray();

                string cmd = input[0];

                if (cmd == "end")
                {
                    Console.WriteLine("Sum: " + stack.Sum());
                    break;
                }

                if (cmd == "add")
                {
                    int firstNumToAdd = int.Parse(input[1]);
                    int secondNumToAdd = int.Parse(input[2]);

                    stack.Push(firstNumToAdd);
                    stack.Push(secondNumToAdd);
                }
                else if (cmd == "remove")
                {
                    int numsToRemove = int.Parse(input[1]);

                    if (stack.Count > numsToRemove)
                    {
                        for (int i = 0; i < numsToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
        }
    }
}
