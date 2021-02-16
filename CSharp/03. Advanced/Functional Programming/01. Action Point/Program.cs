using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            Action<List<string>> printNames = x => Console.WriteLine(string.Join(Environment.NewLine, x));

            printNames(names);
        }
    }
}
