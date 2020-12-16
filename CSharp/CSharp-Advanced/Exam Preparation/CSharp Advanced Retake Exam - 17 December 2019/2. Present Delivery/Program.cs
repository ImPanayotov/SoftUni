using System;

namespace _2._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPresents = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int santaRow = 0;
            int santaCol = 0;
            int niceKids = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Replace(" ", "").ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (input[col] == 'V')
                    {
                        niceKids++;
                    }
                    else if (input[col] == 'S')
                    {
                        santaRow = row;
                        santaCol = col;
                    }
                }
            }

            int niceKidAtStart = niceKids;

            while (true)
            {
                string cmd = Console.ReadLine();

                if (cmd == "Christmas morning")
                {
                    break;
                }

                if (cmd == "up")
                {
                    SantaUp(ref countOfPresents, matrix, ref santaRow, santaCol, ref niceKids);
                }
                else if (cmd == "right")
                {
                    SantaRight(ref countOfPresents, matrix, santaRow, ref santaCol, ref niceKids);
                }
                else if (cmd == "down")
                {
                    SantaDown(ref countOfPresents, matrix, ref santaRow, santaCol, ref niceKids);
                }
                else if (cmd == "left")
                {
                    SantaLeft(ref countOfPresents, matrix, santaRow, ref santaCol, ref niceKids);
                }

                if (countOfPresents == 0)
                {
                    Console.WriteLine("Santa ran out of presents!");
                    break;
                }
            }

            PrintMatrix(matrix);

            if (niceKids == 0)
            {
                Console.WriteLine($"Good job, Santa! {niceKidAtStart} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {niceKids} nice kid/s.");
            }
        }


        private static void PrintMatrix(char[,] matrix)
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

        private static void SantaUp(ref int countOfPresents, char[,] matrix, ref int santaRow, int santaCol, ref int niceKids)
        {
            if (matrix[santaRow - 1, santaCol] == 'X')
            {
                matrix[santaRow - 1, santaCol] = 'S';
                matrix[santaRow, santaCol] = '-';
                santaRow--;
            }
            else if (matrix[santaRow - 1, santaCol] == 'V')
            {
                matrix[santaRow - 1, santaCol] = 'S';
                matrix[santaRow, santaCol] = '-';
                niceKids--;
                countOfPresents--;
                santaRow--;

            }
            else if (matrix[santaRow - 1, santaCol] == 'C')
            {
                matrix[santaRow - 1, santaCol] = 'S';
                matrix[santaRow, santaCol] = '-';
                santaRow--;

                CheckForKids(ref countOfPresents, matrix, santaRow, santaCol, ref niceKids);
            }
            else
            {
                matrix[santaRow - 1, santaCol] = 'S';
                matrix[santaRow, santaCol] = '-';
                santaRow--;
            }
        }

        private static void SantaRight(ref int countOfPresents, char[,] matrix, int santaRow, ref int santaCol, ref int niceKids)
        {
            if (matrix[santaRow, santaCol + 1] == 'X')
            {
                matrix[santaRow, santaCol + 1] = 'S';
                matrix[santaRow, santaCol] = '-';
                santaCol++;
            }
            else if (matrix[santaRow, santaCol + 1] == 'V')
            {
                matrix[santaRow, santaCol + 1] = 'S';
                matrix[santaRow, santaCol] = '-';
                niceKids--;
                countOfPresents--;
                santaCol++;

            }
            else if (matrix[santaRow, santaCol + 1] == 'C')
            {
                matrix[santaRow, santaCol + 1] = 'S';
                matrix[santaRow, santaCol] = '-';
                santaCol++;

                CheckForKids(ref countOfPresents, matrix, santaRow, santaCol, ref niceKids);
            }
            else
            {
                matrix[santaRow, santaCol + 1] = 'S';
                matrix[santaRow, santaCol] = '-';
                santaCol++;
            }
        }

        private static void SantaDown(ref int countOfPresents, char[,] matrix, ref int santaRow, int santaCol, ref int niceKids)
        {
            if (matrix[santaRow + 1, santaCol] == 'X')
            {
                matrix[santaRow + 1, santaCol] = 'S';
                matrix[santaRow, santaCol] = '-';
                santaRow++;
            }
            else if (matrix[santaRow + 1, santaCol] == 'V')
            {
                matrix[santaRow + 1, santaCol] = 'S';
                matrix[santaRow, santaCol] = '-';
                niceKids--;
                countOfPresents--;
                santaRow++;

            }
            else if (matrix[santaRow + 1, santaCol] == 'C')
            {
                matrix[santaRow + 1, santaCol] = 'S';
                matrix[santaRow, santaCol] = '-';
                santaRow++;

                CheckForKids(ref countOfPresents, matrix, santaRow, santaCol, ref niceKids);
            }
            else
            {
                matrix[santaRow + 1, santaCol] = 'S';
                matrix[santaRow, santaCol] = '-';
                santaRow++;
            }
        }

        private static void SantaLeft(ref int countOfPresents, char[,] matrix, int santaRow, ref int santaCol, ref int niceKids)
        {
            if (matrix[santaRow, santaCol - 1] == 'X')
            {
                matrix[santaRow, santaCol - 1] = 'S';
                matrix[santaRow, santaCol] = '-';
                santaCol--;
            }
            else if (matrix[santaRow, santaCol - 1] == 'V')
            {
                matrix[santaRow, santaCol - 1] = 'S';
                matrix[santaRow, santaCol] = '-';
                niceKids--;
                countOfPresents--;
                santaCol--;

            }
            else if (matrix[santaRow, santaCol - 1] == 'C')
            {
                matrix[santaRow, santaCol - 1] = 'S';
                matrix[santaRow, santaCol] = '-';
                santaCol--;

                CheckForKids(ref countOfPresents, matrix, santaRow, santaCol, ref niceKids);
            }
            else
            {
                matrix[santaRow, santaCol - 1] = 'S';
                matrix[santaRow, santaCol] = '-';
                santaCol--;
            }
        }

        private static void CheckForKids(ref int countOfPresents, char[,] matrix, int santaRow, int santaCol, ref int niceKids)
        {
            if (matrix[santaRow - 1, santaCol] == 'X')
            {
                matrix[santaRow - 1, santaCol] = '-';
                countOfPresents--;
            }
            if (matrix[santaRow + 1, santaCol] == 'X')
            {
                matrix[santaRow + 1, santaCol] = '-';
                countOfPresents--;
            }
            if (matrix[santaRow, santaCol - 1] == 'X')
            {
                matrix[santaRow, santaCol - 1] = '-';
                countOfPresents--;
            }
            if (matrix[santaRow, santaCol + 1] == 'X')
            {
                matrix[santaRow, santaCol + 1] = '-';
                countOfPresents--;
            }

            if (matrix[santaRow - 1, santaCol] == 'V')
            {
                matrix[santaRow - 1, santaCol] = '-';
                countOfPresents--;
                niceKids--;
            }
            if (matrix[santaRow + 1, santaCol] == 'V')
            {
                matrix[santaRow + 1, santaCol] = '-';
                countOfPresents--;
                niceKids--;
            }
            if (matrix[santaRow, santaCol - 1] == 'V')
            {
                matrix[santaRow, santaCol - 1] = '-';
                countOfPresents--;
                niceKids--;
            }
            if (matrix[santaRow, santaCol + 1] == 'V')
            {
                matrix[santaRow, santaCol + 1] = '-';
                countOfPresents--;
                niceKids--;
            }
        }
    }
}
