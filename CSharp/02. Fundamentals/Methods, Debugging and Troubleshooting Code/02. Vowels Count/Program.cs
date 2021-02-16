using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that receives a single string and prints the count of the vowels. Use appropriate name for the method.
            string input = Console.ReadLine();
            Console.WriteLine(GetVowelsOfWord(input));
        }

        public static string GetVowelsOfWord(string input)
        {
            int result = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' 
                 || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                {
                    result++;
                }
            }
            return result.ToString();
        }
    }
}
