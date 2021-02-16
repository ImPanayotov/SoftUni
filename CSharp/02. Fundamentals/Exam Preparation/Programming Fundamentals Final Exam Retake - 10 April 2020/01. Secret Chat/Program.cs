using System;
using System.Linq;
using System.Text;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = Console.ReadLine();

            while (true)
            {
                string[] input = Console.ReadLine().Split(":|:").ToArray();

                string cmd = input[0];

                if (cmd == "Reveal")
                {
                    Console.WriteLine($"You have a new text message: {msg}");
                    break;
                }

                if (cmd == "InsertSpace")
                {
                    int index = int.Parse(input[1]);
                    msg = msg.Insert(index, " ");

                    Console.WriteLine(msg);

                }
                else if (cmd == "Reverse")
                {
                    string substring = input[1];

                    if (msg.Contains(substring))
                    {
                        int index = msg.IndexOf(substring);
                        int length = substring.Length;

                        msg = msg.Remove(index, length);
                        char[] ch = substring.ToCharArray();

                        msg += string.Join("", ch.Reverse());

                        Console.WriteLine(msg);

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmd == "ChangeAll")
                {
                    string substring = input[1];
                    string replacement = input[2];
                    if (msg.Contains(substring))
                    {
                        msg = msg.Replace(substring, replacement);
                        Console.WriteLine(msg);

                    }
                }
            }
        }
    }
}
