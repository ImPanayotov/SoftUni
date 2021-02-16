using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

            while (true)
            {
                List<string> input = Console.ReadLine()
                    .Split()
                    .ToList();

                if (input[0] == "end")
                {
                    break;
                }
                if (input[0] == "Insert")
                {
                    int index = int.Parse(input[2]);
                    int value = int.Parse(input[1]);
                    numbers.Insert(index, value);
                }
                else if (input[0] == "Delete")
                {
                    int numberToRemove = int.Parse(input[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numberToRemove == numbers[i])
                        {
                            numbers.RemoveAt(i);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
