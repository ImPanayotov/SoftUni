using System;
using System.Linq;

namespace _01._Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = Console.ReadLine();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                string cmd = input[0];

                if (cmd == "Finish")
                {
                    break;
                }

                if (cmd == "Replace")
                {
                    char ch = char.Parse(input[1]);
                    char replacement = char.Parse(input[2]);

                    msg = msg.Replace(ch, replacement);

                    Console.WriteLine(msg);
                }
                else if (cmd == "Cut")
                {
                    int start = int.Parse(input[1]);
                    int end = int.Parse(input[2]);

                    if (start >=0 && start < msg.Length && end >= 0 && end < msg.Length && start <= end)
                    {
                        msg = msg.Remove(start, end - start + 1);

                        Console.WriteLine(msg);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                else if (cmd == "Make")
                {
                    string upperOrLower = input[1];

                    if (upperOrLower == "Upper")
                    {
                        msg = msg.ToUpper();
                    }
                    else if (upperOrLower == "Lower")
                    {
                        msg = msg.ToLower();
                    }

                    Console.WriteLine(msg);
                }
                else if (cmd == "Check")
                {
                    string strToCheck = input[1];

                    if (msg.Contains(strToCheck))
                    {
                        Console.WriteLine($"Message contains {strToCheck}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {strToCheck}");
                    }
                }
                else if (cmd == "Sum")
                {
                    int start = int.Parse(input[1]);
                    int end = int.Parse(input[2]);

                    if (start >= 0 && start < msg.Length && end >= 0 && end < msg.Length && start <= end)
                    {
                        char[] substring = msg.Substring(start, end - start + 1).ToCharArray();

                        int sum = 0;

                        for (int i = 0; i < substring.Length; i++)
                        {
                            sum += substring[i];
                        }

                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
            }
        }
    }
}
