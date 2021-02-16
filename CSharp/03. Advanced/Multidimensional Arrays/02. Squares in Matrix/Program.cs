using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] matrix = new char[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                List<char> colElements = new List<char>();

                for (int i = 0; i < input.Length; i++)
                {
                    if (!char.IsWhiteSpace(input[i]))
                    {
                        colElements.Add(input[i]);
                    }
                }

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int count = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char topLeft = matrix[row, col];
                    char bottomLeft = matrix[row + 1, col];
                    char topRight = matrix[row, col + 1];
                    char bottomRight = matrix[row + 1, col + 1];

                    if (topLeft == bottomLeft && bottomLeft == topRight && topRight == bottomRight)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
