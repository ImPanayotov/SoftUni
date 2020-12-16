using System;
using System.Linq;

namespace _06._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jagged = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

                jagged[i] = new double[input.Length];

                for (int j = 0; j < input.Length; j++)
                {
                    jagged[i][j] = input[j];
                }
            }

            for (int row = 0; row < jagged.Length - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;

                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string cmd = input[0];

                if (cmd == "End")
                {
                    break;
                }

                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                double value = double.Parse(input[3]);

                if (cmd == "Add")
                {
                    if (row <= jagged.GetLength(0) - 1 && row >= 0 && col <= jagged[row].Length - 1 && col >= 0)
                    {
                        jagged[row][col] += value;
                    }
                }
                else if (cmd == "Subtract")
                {
                    if (row <= jagged.GetLength(0) - 1 && row >= 0 && col <= jagged[row].Length - 1 && col >= 0)
                    {
                        jagged[row][col] -= value;
                    }
                }
            }

            printJagged(jagged);
        }

        private static void printJagged(double[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
