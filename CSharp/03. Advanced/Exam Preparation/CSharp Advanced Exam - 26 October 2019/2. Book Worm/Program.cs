using System;
using System.Text;

namespace _2._Book_Worm
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder worm = new StringBuilder(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
                                                                                       
            while (true)
            {
                string cmd = Console.ReadLine();

                if (cmd == "end")
                {
                    break;
                }

                if (cmd == "up")
                {
                    if (playerRow - 1 >= 0 && playerRow - 1 < matrix.GetLength(0))
                    {
                        if (char.IsLetter(matrix[playerRow - 1, playerCol]))
                        {
                            worm.Append(matrix[playerRow - 1, playerCol]);

                        }

                        matrix[playerRow, playerCol] = '-';
                        matrix[playerRow - 1, playerCol] = 'P';

                        playerRow--;
                    }
                    else
                    {
                        if (worm.Length > 0)
                        {
                            worm.Remove(worm.Length - 1, 1);
                        }
                    }
                }
                else if (cmd == "right")
                {
                    if (playerCol + 1 >= 0 && playerCol + 1 < matrix.GetLength(1))
                    {
                        if (char.IsLetter(matrix[playerRow, playerCol + 1]))
                        {
                            worm.Append(matrix[playerRow, playerCol + 1]);
                        }

                        matrix[playerRow, playerCol] = '-';
                        matrix[playerRow, playerCol + 1] = 'P';

                        playerCol++;
                    }
                    else
                    {
                        if (worm.Length > 0)
                        {
                            worm.Remove(worm.Length - 1, 1);
                        }
                    }
                }
                else if (cmd == "down")
                {
                    if (playerRow + 1 >= 0 && playerRow + 1 < matrix.GetLength(0))
                    {
                        if (char.IsLetter(matrix[playerRow + 1, playerCol]))
                        {
                            worm.Append(matrix[playerRow + 1, playerCol]);
                        }

                        matrix[playerRow, playerCol] = '-';
                        matrix[playerRow + 1, playerCol] = 'P';

                        playerRow++;
                    }
                    else
                    {
                        if (worm.Length > 0)
                        {
                            worm.Remove(worm.Length - 1, 1);
                        }
                    }
                }
                else if (cmd == "left")
                {
                    if (playerCol - 1 >= 0 && playerCol - 1 < matrix.GetLength(1))
                    {
                        if (char.IsLetter(matrix[playerRow, playerCol - 1]))
                        {
                            worm.Append(matrix[playerRow, playerCol - 1]);
                        }

                        matrix[playerRow, playerCol] = '-';
                        matrix[playerRow, playerCol - 1] = 'P';

                        playerCol--;
                    }
                    else
                    {
                        if (worm.Length > 0)
                        {
                            worm.Remove(worm.Length - 1, 1);
                        }
                    }
                }
            }

            if (worm.Length > 0)
            {
                Console.WriteLine(worm);
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
