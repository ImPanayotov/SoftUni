using System;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //int leftLenght = input[0].Length;
            //int rightLenght = input[1].Length;

            BigInteger sum = 0;
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    string[] input = Console.ReadLine().Split();
                    BigInteger left = BigInteger.Parse(input[0]);
                    BigInteger right = BigInteger.Parse(input[1]);

                    if (left > right)
                    {
                        while (left != 0)
                        {
                            sum += left % 10;
                            left /= 10;
                        }
                        Console.WriteLine(BigInteger.Abs(sum));
                        sum = 0;
                    }
                    else
                    {
                        while (right != 0)
                        {
                            sum += right % 10;
                            right /= 10;
                        }
                        Console.WriteLine(BigInteger.Abs(sum));
                        sum = 0;
                    }
                }
            }
        }
    }
}
