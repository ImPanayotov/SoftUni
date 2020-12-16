using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (var symbol in input)
            {
                if (stack.Any())
                {
                    char check = stack.Peek();
                    if (check == '{' && symbol == '}')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (check == '[' && symbol == ']')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (check == '(' && symbol == ')')
                    {
                        stack.Pop();
                        continue;
                    }
                }
                stack.Push(symbol);
            }
            Console.WriteLine(!stack.Any() ? "YES" : "NO");
        }
    }
}

