using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ranges = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int start = ranges[0];
            int end = ranges[1];

            string criteria = Console.ReadLine();

            Func<int, int, List<int>> generateList = (start, end) =>
            {
                List<int> nums = new List<int>();

                for (int i = start; i <= end; i++)
                {
                    nums.Add(i);

                }

                return nums;
            };

            List<int> numbers = generateList(start, end);

            Predicate<int> predicate = n => n % 2 == 0;

            if (criteria == "odd")
            {
                predicate = n => n % 2 != 0;
            }

            numbers = MyWhere(numbers, predicate);

            //numbers = numbers.Where(evenPredicate).ToList();
            //Func<int, bool> evenPredicate = n => n % 2 == 0;

            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> MyWhere(List<int> items, Predicate<int> predicate)
        {
            List<int> result = new List<int>();

            foreach (var item in items)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
