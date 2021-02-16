using System;
using System.Linq;

namespace _03._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] cube = new int[size, size];

            for (int row = 0; row < cube.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cube.GetLength(0); col++)
                {
                    cube[row, col] = colElements[col];
                }
            }

            int sum = 0;

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                sum += cube[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}
