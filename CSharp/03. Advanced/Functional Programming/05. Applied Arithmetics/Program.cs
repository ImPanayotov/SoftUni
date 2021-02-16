using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> addFunc = x => x + 1;
            Func<int, int> multiplyFunc = x => x * 2;
            Func<int, int> subtractFunc = x => x - 1;
            Action<int[]> printFunc = x => Console.WriteLine(string.Join(" ", x));

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = numbers.Select(addFunc).ToList();
                        break;

                    case "multiply":
                        numbers = numbers.Select(multiplyFunc).ToList();
                        break;

                    case "subtract":
                        numbers = numbers.Select(subtractFunc).ToList();
                        break;

                    case "print":
                        printFunc(numbers.ToArray());
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
