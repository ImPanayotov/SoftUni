using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            char[] first = input[0].ToCharArray();
            char[] second = input[1].ToCharArray();

            int sum = 0;
            int minLength = Math.Min(first.Length, second.Length);
            int maxLength = Math.Max(first.Length, second.Length);

            if (first.Length > second.Length)
            {
                for (int i = 0; i < minLength; i++)
                {
                    sum += first[i] * second[i];
                }

                for (int i = minLength; i < maxLength; i++)
                {
                    sum += first[i];
                }
            }
            else if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    sum += first[i] * second[i];
                }
            }
            else
            {
                for (int i = 0; i < minLength; i++)
                {
                    sum += first[i] * second[i];
                }

                for (int i = minLength; i < maxLength; i++)
                {
                    sum += second[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
