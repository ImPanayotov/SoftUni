using System;

namespace _02._Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int beeRow = 0;
            int beeCol = 0;

            int pollinatedFlowers = 0;

            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }

            while (true)
            {
                string cmd = Console.ReadLine();

                if (cmd == "End")
                {
                    break;
                }

                if (cmd == "right")
                {
                    if (beeCol + 1 > n - 1)
                    {
                        Console.WriteLine("The bee got lost!");
                        matrix[beeRow, beeCol] = '.';

                        break;
                    }
                    else
                    {
                        if (matrix[beeRow, beeCol + 1] == 'f')
                        {
                            pollinatedFlowers++;
                        }

                        if (matrix[beeRow, beeCol + 1] == 'O')
                        {
                            matrix[beeRow, beeCol + 1] = '.';

                            if (matrix[beeRow, beeCol + 2] == 'f')
                            {
                                pollinatedFlowers++;
                            }

                            matrix[beeRow, beeCol] = '.';
                            matrix[beeRow, beeCol + 2] = 'B';
                            beeCol += 2;
                            continue;
                        }

                        matrix[beeRow, beeCol] = '.';
                        matrix[beeRow, beeCol + 1] = 'B';
                        beeCol++;
                    }
                }
                else if (cmd == "left")
                {
                    if (beeCol - 1 < 0)
                    {

                        Console.WriteLine("The bee got lost!");
                        matrix[beeRow, beeCol] = '.';

                        break;

                    }
                    else
                    {
                        if (matrix[beeRow, beeCol - 1] == 'f')
                        {
                            pollinatedFlowers++;
                        }

                        if (matrix[beeRow, beeCol - 1] == 'O')
                        {
                            matrix[beeRow, beeCol - 1] = '.';

                            if (matrix[beeRow, beeCol - 2] == 'f')
                            {
                                pollinatedFlowers++;
                            }

                            matrix[beeRow, beeCol] = '.';
                            matrix[beeRow, beeCol - 2] = 'B';
                            beeCol -= 2;
                            continue;
                        }

                        matrix[beeRow, beeCol] = '.';
                        matrix[beeRow, beeCol - 1] = 'B';
                        beeCol--;
                    }
                }
                else if (cmd == "up")
                {
                    if (beeRow - 1 < 0)
                    {
                        Console.WriteLine("The bee got lost!");
                        matrix[beeRow, beeCol] = '.';

                        break;
                    }
                    else
                    {
                        if (matrix[beeRow - 1, beeCol] == 'f')
                        {
                            pollinatedFlowers++;
                        }

                        if (matrix[beeRow - 1, beeCol] == 'O')
                        {
                            matrix[beeRow - 1, beeCol] = '.';

                            if (matrix[beeRow - 2, beeCol] == 'f')
                            {
                                pollinatedFlowers++;
                            }
                            matrix[beeRow, beeCol] = '.';

                            matrix[beeRow - 2, beeCol] = 'B';
                            beeRow -= 2;
                            continue;
                        }
                    }

                    matrix[beeRow, beeCol] = '.';
                    matrix[beeRow - 1, beeCol] = 'B';
                    beeRow--;
                }

                else if (cmd == "down")
                {
                    if (beeRow + 1 > n - 1)
                    {
                        Console.WriteLine("The bee got lost!");
                        matrix[beeRow, beeCol] = '.';

                        break;

                    }
                    else
                    {
                        if (matrix[beeRow + 1, beeCol] == 'f')
                        {
                            pollinatedFlowers++;
                        }

                        if (matrix[beeRow + 1, beeCol] == 'O')
                        {
                            matrix[beeRow + 1, beeCol] = '.';

                            if (matrix[beeRow + 2, beeCol] == 'f')
                            {
                                pollinatedFlowers++;
                            }
                            matrix[beeRow, beeCol] = '.';

                            matrix[beeRow + 2, beeCol] = 'B';
                            beeRow += 2;
                            continue;
                        }

                        matrix[beeRow, beeCol] = '.';
                        matrix[beeRow + 1, beeCol] = 'B';
                        beeRow++;
                    }
                }
            }

            if (pollinatedFlowers <= 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
            }

            Print(matrix);
        }

        private static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
