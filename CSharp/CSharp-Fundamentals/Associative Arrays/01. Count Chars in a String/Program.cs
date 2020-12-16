using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, uint> histogram = new Dictionary<char, uint>();

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char currenChar = text[i];

                if (currenChar != ' ')
                {
                    if (!histogram.ContainsKey(currenChar))
                    {
                        histogram[currenChar] = 0;
                    }

                    histogram[currenChar]++;
                }
            }

            foreach (var item in histogram)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
