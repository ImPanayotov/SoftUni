using System;

namespace _08._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                var result = GetMax(first, second);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char result = GetMax(first, second);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string result = GetMax(first, second);
                Console.WriteLine(result);
            }
        }


        static int GetMax(int first, int second)
        {
            var result = 0;
            if (first > second)
            {
                result = first;
            }
            else if (first < second)
            {
                result = second;
            }
            return result;
        }
        static char GetMax(char first, char second)
        {
            char result = (char)0x00;
            if (first > second)
            {
                result = first;

            }
            else if (first < second)
            {
                result = second;
            }
            return result;
        }

        static string GetMax(string first, string second)
        {
            string result = string.Empty;
            if (first.CompareTo(second) > 0)
            {
                result = first;
            }
            else if (first.CompareTo(second) < 0)
            {
                result = second;
            }
            return result;
        }
    }
}
