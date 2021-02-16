using System;

namespace _02._Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            FillMatrix(n, matrix);

            int foodQty = 0;

            int snakeRow = 0;
            int snakeCol = 0;

            // Finding snake's start position
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                }
            }

            while (true)
            {
                string cmd = Console.ReadLine();

                if (cmd == "up")
                {
                    if (snakeRow - 1 >= 0 && snakeRow - 1 < matrix.GetLength(0))
                    {
                        if (matrix[snakeRow - 1, snakeCol] == '*')
                        {
                            foodQty++;
                            matrix[snakeRow, snakeCol] = '.';
                            matrix[snakeRow - 1, snakeCol] = 'S';
                            snakeRow--;
                        }
                        else if (matrix[snakeRow - 1, snakeCol] == 'B')
                        {
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    if (matrix[row, col] == 'B' && row != snakeRow && col != snakeCol)
                                    {
                                        matrix[snakeRow, snakeCol] = '.';
                                        matrix[snakeRow - 1, snakeCol] = '.';
                                        matrix[row, col] = 'S';
                                        snakeRow = row;
                                        snakeCol = col;
                                    }
                                }
                            }
                        }
                        else
                        {
                            matrix[snakeRow, snakeCol] = '.';
                            matrix[snakeRow - 1, snakeCol] = 'S';
                            snakeRow--;
                        }
                    }
                    else
                    {
                        matrix[snakeRow, snakeCol] = '.';
                        Console.WriteLine("Game over!");
                        break;
                    }
                }
                else if (cmd == "right")
                {
                    if (snakeCol + 1 >= 0 && snakeCol + 1 < matrix.GetLength(1))
                    {
                        if (matrix[snakeRow, snakeCol + 1] == '*')
                        {
                            foodQty++;
                            matrix[snakeRow, snakeCol] = '.';
                            matrix[snakeRow, snakeCol + 1] = 'S';
                            snakeCol++;
                        }
                        else if (matrix[snakeRow, snakeCol + 1] == 'B')
                        {
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    if (matrix[row, col] == 'B' && row != snakeRow && col != snakeCol)
                                    {
                                        matrix[snakeRow, snakeCol] = '.';
                                        matrix[snakeRow, snakeCol + 1] = '.';
                                        matrix[row, col] = 'S';
                                        snakeRow = row;
                                        snakeCol = col;
                                    }
                                }
                            }
                        }
                        else
                        {
                            matrix[snakeRow, snakeCol] = '.';
                            matrix[snakeRow, snakeCol + 1] = 'S';
                            snakeCol++;
                        }
                    }
                    else
                    {
                        matrix[snakeRow, snakeCol] = '.';
                        Console.WriteLine("Game over!");
                        break;
                    }
                }
                else if (cmd == "down")
                {
                    if (snakeRow + 1 >= 0 && snakeRow + 1 < matrix.GetLength(0))
                    {
                        if (matrix[snakeRow + 1, snakeCol] == '*')
                        {
                            foodQty++;
                            matrix[snakeRow, snakeCol] = '.';
                            matrix[snakeRow + 1, snakeCol] = 'S';
                            snakeRow++;
                        }
                        else if (matrix[snakeRow + 1, snakeCol] == 'B')
                        {
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    if (matrix[row, col] == 'B' && row != snakeRow && col != snakeCol)
                                    {
                                        matrix[snakeRow, snakeCol] = '.';
                                        matrix[snakeRow + 1, snakeCol] = '.';
                                        matrix[row, col] = 'S';
                                        snakeRow = row;
                                        snakeCol = col;
                                    }
                                }
                            }
                        }
                        else
                        {
                            matrix[snakeRow, snakeCol] = '.';
                            matrix[snakeRow + 1, snakeCol] = 'S';
                            snakeRow++;
                        }
                    }
                    else
                    {
                        matrix[snakeRow, snakeCol] = '.';
                        Console.WriteLine("Game over!");
                        break;
                    }
                }
                else if (cmd == "left")
                {
                    if (snakeCol - 1 >= 0 && snakeCol - 1 < matrix.GetLength(1))
                    {
                        if (matrix[snakeRow, snakeCol - 1] == '*')
                        {
                            foodQty++;
                            matrix[snakeRow, snakeCol] = '.';
                            matrix[snakeRow, snakeCol - 1] = 'S';
                            snakeCol--;
                        }
                        else if (matrix[snakeRow, snakeCol - 1] == 'B')
                        {
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    if (matrix[row, col] == 'B' && row != snakeRow && col != snakeCol)
                                    {
                                        matrix[snakeRow, snakeCol] = '.';
                                        matrix[snakeRow, snakeCol - 1] = '.';
                                        matrix[row, col] = 'S';
                                        snakeRow = row;
                                        snakeCol = col;
                                    }
                                }
                            }
                        }
                        else
                        {
                            matrix[snakeRow, snakeCol] = '.';
                            matrix[snakeRow, snakeCol - 1] = 'S';
                            snakeCol--;
                        }
                    }
                    else
                    {
                        matrix[snakeRow, snakeCol] = '.';
                        Console.WriteLine("Game over!");
                        break;
                    }
                }

                if (foodQty >= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    break;
                }
            }

            Console.WriteLine($"Food eaten: {foodQty}");
            PrintMatrix(matrix);

        }

        private static void PrintMatrix(char[,] matrix)
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

        private static void FillMatrix(int n, char[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
