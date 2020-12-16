using System;
using System.Linq;

namespace _01._Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = input[0];

                if (command == "Complete")
                {
                    break;
                }

                if (command == "Make")
                {
                    string subCommand = input[1];

                    if (subCommand == "Upper")
                    {
                        email = email.ToUpper();
                    }
                    else if (subCommand == "Lower")
                    {
                        email = email.ToLower();
                    }

                    Console.WriteLine(email);
                }
                else if (command == "GetDomain")
                {
                    int count = int.Parse(input[1]);
                    char[] ch = email.TakeLast(count).ToArray();
                    Console.WriteLine(string.Join("", ch));
                }
                else if (command == "GetUsername")
                {
                    string emailToPrint = string.Empty;

                    if (!email.Contains('@'))
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                    else
                    {
                        char[] ch = email.TakeWhile(x => x != '@').ToArray();

                        Console.WriteLine(string.Join("", ch));
                    }
                }
                else if (command == "Replace")
                {
                    char ch = char.Parse(input[1]);
                    email = email.Replace(ch, '-');

                    Console.WriteLine(email);
                }
                else if (command == "Encrypt")
                {
                    char[] ASCII = email.ToCharArray();

                    foreach (char ch in ASCII)
                    {
                        Console.Write((int)ch + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
