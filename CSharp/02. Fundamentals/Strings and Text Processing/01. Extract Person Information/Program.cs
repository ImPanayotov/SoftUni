using System;
using System.Text;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                int nameIndex1 = input.IndexOf('@') + 1;
                int nameIndex2 = input.IndexOf('|');
                int ageIndex1 = input.IndexOf('#') + 1;
                int ageIndex2 = input.IndexOf('*');

                int nameCharCount = nameIndex2 - nameIndex1;
                int ageCharCount = ageIndex2 - ageIndex1;

                string name = input.Substring(nameIndex1, nameCharCount);
                string age = input.Substring(ageIndex1, ageCharCount);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
