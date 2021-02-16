using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
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
                string input = Console.ReadLine();
                    
                if (input == "end")
                {
                    break;
                }
                string[] elements = input.Split();
                if (elements[0] == "Add")
                {
                    int add = int.Parse(elements[1]);
                    numbers.Add(add);
                }
                else if (elements[0] == "Remove")
                {
                    int remove = int.Parse(elements[1]);
                    numbers.Remove(remove);
                }
                else if (elements[0] == "RemoveAt")
                {
                    int removeAt = int.Parse(elements[1]);
                    numbers.RemoveAt(removeAt);
                }
                else if (elements[0] == "Insert")
                {
                    int insertNumber = int.Parse(elements[1]);
                    int insertIndex = int.Parse(elements[2]);
                    numbers.Insert(insertIndex, insertNumber);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
