using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var counter = a1.Length;

            while (counter > 1)
            {
                for (int i = 0; i < a1.Length - 1; i++)
                {
                    a1[i] = a1[i] + a1[i + 1];

                }
                counter--;
            }
            Console.WriteLine(a1[0]);
        }
    }
}
