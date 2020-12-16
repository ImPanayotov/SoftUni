using System;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = dimensions[0];
            int m = dimensions[1];
            int[,] matrix = new int[n, m];

            string input = Console.ReadLine();

            while (input != "Bloom Bloom Plow")
            {
                int[] coordinates = input.Split().Select(int.Parse).ToArray();
                int row = coordinates[0];
                int col = coordinates[1];

                if (row < 0 || col < 0 || row >= n || col >= m)
                {
                    Console.WriteLine("Invalid coordinates.");
                    input = Console.ReadLine();
                    continue;
                }
                matrix[row, col]++;
                for (int i = 0; i < n; i++)
                {
                    if (i != row)
                    {
                        matrix[i, col]++;
                    }

                }
                for (int i = 0; i < m; i++)
                {
                    if (i != col)
                    {
                        matrix[row, i]++;
                    }

                }


                input = Console.ReadLine();
            }

            PrinMatrix(matrix);
        }

        static void PrinMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
