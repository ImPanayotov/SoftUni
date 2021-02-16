using System;
using System.Linq;

namespace _4._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

            int rotations = int.Parse(Console.ReadLine());
            int realRotation = rotations % numbers.Length;
            for (int i = 0; i < realRotation; i++)
            {
                int firstNumber = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Length - 1] = firstNumber;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
