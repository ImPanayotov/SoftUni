using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] box = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(box);

            int capacity = int.Parse(Console.ReadLine());

            int racks = 1;
            int sum = 0;
            //5 4 8 6 3 8 7 7 9
            

            while (stack.Count > 0)
            {
                int current = stack.Peek();
                if (stack.Peek() + sum <= capacity)
                {
                    sum += stack.Pop();
                }
                else
                {
                    racks++;
                    sum = 0;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
