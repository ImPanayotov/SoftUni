using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            var gardenDimensions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var garden = new int[gardenDimensions[0]][];
            var seeds = new List<int[]>();

            for (int rowIndex = 0; rowIndex < garden.Length; rowIndex++)
            {
                garden[rowIndex] = new int[gardenDimensions[1]];
            }

            var inputLine = Console.ReadLine();

            while (inputLine != "Bloom Bloom Plow")
            {
                var inputData = inputLine
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                var seedRow = inputData[0];
                var seedCol = inputData[1];

                if (seedRow >= 0 && seedRow < garden.Length && seedCol >= 0 && seedCol < garden[0].Length)
                {
                    garden[seedRow][seedCol] = -1;
                    seeds.Add(inputData);
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                inputLine = Console.ReadLine();
            }

            for (int seed = 0; seed < seeds.Count; seed++)
            {
                BloomFlowers(garden, seeds[seed][0], seeds[seed][1]);
            }

            StringBuilder sb = new StringBuilder();




            foreach (var flower in garden)
            {
                sb.AppendLine(string.Join(" ", flower));
            }
            Console.WriteLine(sb.ToString().Trim());
        }

        private static void BloomFlowers(int[][] garden, int row, int col)
        {
            for (int i = 0; i < garden.Length; i++)
            {
                garden[i][col]++;
            }

            for (int j = 0; j < garden[row].Length; j++)
            {
                garden[row][j]++;
            }
        }
    }
}
