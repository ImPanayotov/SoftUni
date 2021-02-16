using System;
using System.Linq;

namespace _01._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int primarySum = 0;
            int secondarySum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primarySum += matrix[i, i];
                secondarySum += matrix[i, (matrix.GetLength(1) - 1) - i];
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}
