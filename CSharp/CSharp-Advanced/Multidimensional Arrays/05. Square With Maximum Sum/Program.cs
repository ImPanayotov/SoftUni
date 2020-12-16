using System;
using System.Linq;

namespace _05._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int sum = 0;
            int topLeft = 0;
            int bottomLeft = 0;
            int topRight = 0;
            int bottomRight = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        topLeft = matrix[row, col];
                        bottomLeft = matrix[row + 1, col];
                        topRight = matrix[row, col + 1];
                        bottomRight = matrix[row + 1, col + 1];
                    }
                }
            }

            Console.WriteLine($"{topLeft} {topRight}");
            Console.WriteLine($"{bottomLeft} {bottomRight}");
            Console.WriteLine(sum);
        }
    }
}
