using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];

                if (command == "end")
                {
                    Console.WriteLine(string.Join(", ", arr));
                    break;
                }

                if (command == "swap")
                {
                    int index1 = int.Parse(input[1]);
                    int index2 = int.Parse(input[2]);

                    Swap(arr, index1, index2);

                }
                else if (command == "multiply")
                {
                    int index1 = int.Parse(input[1]);
                    int index2 = int.Parse(input[2]);

                    Multiply(arr, index1, index2);
                }
                else if (command == "decrease")
                {
                    Decrease(arr);
                }
            }
        }

        public static int[] Swap(int[] arr, int index1, int index2)
        {
            if (index1 >=0 && index1 < arr.Length && index2 >= 0 && index2 < arr.Length)
            {
                int temp = arr[index1];
                arr[index1] = arr[index2];
                arr[index2] = temp;
            }

            return arr;
        }

        public static int[] Multiply(int[] arr, int index1, int index2)
        {
            if (index1 >= 0 && index1 < arr.Length && index2 >= 0 && index2 < arr.Length)
            {
                arr[index1] *= arr[index2];
            }

            return arr;
        }

        public static int[] Decrease(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] -= 1;
            }

            return arr;
        }
    }
}
