using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            int rotation = n % arr.Length;
            if (n == arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i < rotation; i++)
                {
                    int firstNumber = arr[0];
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[arr.Length - 1] = firstNumber;
                }
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
