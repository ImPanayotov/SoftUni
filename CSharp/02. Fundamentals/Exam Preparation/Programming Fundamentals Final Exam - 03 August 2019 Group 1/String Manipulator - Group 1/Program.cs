using System;
using System.Linq;
using System.Text;

namespace String_Manipulator___Group_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // StringBuilder str = new StringBuilder(Console.ReadLine());
            string str = Console.ReadLine();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];

                if (command == "End")
                {
                    break;
                }

                if (command == "Translate")
                {
                    char ch = char.Parse(input[1]);
                    char replacement = char.Parse(input[2]);

                    str = str.Replace(ch, replacement);

                    Console.WriteLine(str);
                }
                else if (command == "Includes")
                {
                    string strToCheck = input[1];
                    Console.WriteLine(str.Contains(strToCheck));
                }
                else if (command == "Start")
                {
                    string strStart = input[1];

                    Console.WriteLine(str.StartsWith(strStart));

                }
                else if (command == "Lowercase")
                {
                    char[] chArr = str.ToCharArray();
                    for (int i = 0; i < chArr.Length; i++)
                    {
                        if (char.IsUpper(chArr[i]))
                        {
                            chArr[i] = char.ToLower(chArr[i]);
                        }
                    }

                    str = string.Join("", chArr);
                    Console.WriteLine(str);
                }
                else if (command== "FindIndex")
                {
                    char ch = char.Parse(input[1]);
                    char[] chArr = str.ToCharArray();

                    int index = 0;

                    for (int i = 0; i < chArr.Length; i++)
                    {
                        if (chArr[i] == ch)
                        {
                            index = i;
                        }
                    }
                    Console.WriteLine(index);

                }
                else if (command == "Remove")
                {
                    int start = int.Parse(input[1]);
                    int count = int.Parse(input[2]);

                    str = str.Remove(start, count);

                    Console.WriteLine(str);
                }
            }
        }
    }
}
