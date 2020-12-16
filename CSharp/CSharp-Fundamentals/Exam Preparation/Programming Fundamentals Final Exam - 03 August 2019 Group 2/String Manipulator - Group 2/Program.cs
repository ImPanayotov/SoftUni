using System;
using System.Linq;

namespace String_Manipulator___Group_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];

                if (command == "Done")
                {
                    break;
                }

                if (command == "Change")
                {
                    char ch = char.Parse(input[1]);
                    char replacement = char.Parse(input[2]);

                    str = str.Replace(ch, replacement);

                    Console.WriteLine(str);
                }
                else if (command == "Includes")
                {
                    string includes = input[1];

                    Console.WriteLine(str.Contains(includes));
                }
                else if (command == "End")
                {
                    string edning = input[1];

                    Console.WriteLine(str.EndsWith(edning));
                }
                else if (command == "Uppercase")
                {
                    str = str.ToUpper();

                    Console.WriteLine(str);
                }
                else if (command == "FindIndex")
                {
                    char ch = char.Parse(input[1]);
                    int index = str.IndexOf(ch);

                    Console.WriteLine(index);
                }
                else if (command == "Cut")
                {
                    int start = int.Parse(input[1]);
                    int length = int.Parse(input[2]);
                    string newStr = string.Empty;

                    for (int i = 0; i < str.Length; i++)
                    {
                        if (i >= start && i < start + length)
                        {
                            newStr += str[i];
                        }
                    }

                    str = newStr;

                    Console.WriteLine(str);
                }
            }
        }
    }
}
