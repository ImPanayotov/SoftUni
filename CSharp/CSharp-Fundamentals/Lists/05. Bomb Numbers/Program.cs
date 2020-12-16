using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < sequence.Count;)
            {
                if (sequence[i] == arr[0])
                {
                    int start = i - arr[1];
                    if (start < 0)
                    {
                        start = 0;
                    }

                    int finish = i + arr[1] + 1;
                    if (finish > sequence.Count)
                    {
                        finish = sequence.Count;
                    }

                    for (int j = start; j < finish; j++)
                    {
                        sequence[j] = 0;
                    }
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(sequence.Sum());
        }
    }
}
