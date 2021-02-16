using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Stack<string> stack = new Stack<string>(input.Reverse());

            int result = 0;

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string cmd = stack.Pop();
                int second = int.Parse(stack.Pop());

                if (cmd == "+")
                {
                    result = first + second;
                    stack.Push(result.ToString());
                }
                else if (cmd == "-")
                {
                    result = first - second;
                    stack.Push(result.ToString());
                }
            }

            Console.WriteLine(result);
        }
    }
}
