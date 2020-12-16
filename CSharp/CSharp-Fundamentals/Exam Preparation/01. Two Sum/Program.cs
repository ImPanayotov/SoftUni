using System;
using System.Linq;

namespace _01._Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int target = int.Parse(Console.ReadLine());

            foreach (int item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
