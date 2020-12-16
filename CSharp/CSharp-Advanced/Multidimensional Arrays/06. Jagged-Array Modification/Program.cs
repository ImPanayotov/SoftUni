using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];

            for (int row = 0; row < jagged.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jagged[row] = new int[colElements.Length];

                for (int col = 0; col < colElements.Length; col++)
                {
                    jagged[row][col] = colElements[col];
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string cmd = input[0];

                if (cmd == "END")
                {
                    break;
                }

                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if (row >= 0 && row < jagged.GetLength(0) && col >= 0 && col < jagged[row].Length)
                {
                    if (cmd == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else if (cmd == "Subtract")
                    {
                        jagged[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
            }

            foreach (int[] row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
