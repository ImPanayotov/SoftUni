using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine() 
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            while (sequence.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                
                if (index < 0)
                {
                    index = 0;
                    sum += sequence[index];
                    Pokemon(index, sequence);
                    int last = sequence.Last();
                    sequence.Insert(index, last);
                }
                else if (index > sequence.Count - 1) 
                {
                    index = sequence.Count - 1;
                    sum += sequence[index];
                    Pokemon(index, sequence);
                    sequence.Add(sequence[0]);            
                }
                else
                {
                    sum += sequence[index];
                    Pokemon(index, sequence);
                }
            }
            Console.WriteLine(sum);
        }

        public static List<int> Pokemon(int index, List<int> sequence)
        {

            int value = sequence[index];
            sequence.RemoveAt(index);
            for (int i = 0; i < sequence.Count; i++)
            {
                if (value >= sequence[i])
                {
                    sequence[i] += value;
                }
                else
                {
                    sequence[i] -= value;
                }
            }
            return sequence;
        }
    }
}
