using System;

namespace _07._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] pascal = new long[n][];

            for (int row = 0; row < n; row++)
            {
                pascal[row] = new long[row + 1];

                for (int col = 0; col < row + 1; col++)
                {
                    if (col > 0 && col < pascal[row].Length - 1)
                    {

                    pascal[row][col] = pascal[row - 1][col - 1] + pascal[row - 1][col];
                    }
                    else
                    {
                        pascal[row][col] = 1;
                    }
                }
            }

            foreach (var row in pascal)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
