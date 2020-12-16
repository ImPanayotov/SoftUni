using System;
using System.Linq;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];

                if (command == "Done")
                {
                    Console.WriteLine($"Your password is: {password}");
                    break;
                }

                if (command == "TakeOdd")
                {
                    StringBuilder newPassword = new StringBuilder();

                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            newPassword.Append(password[i]);
                        }
                    }

                    password = newPassword.ToString();

                    Console.WriteLine(password);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(input[1]);
                    int length = int.Parse(input[2]);

                    if (index >= 0 && index < password.Length
                        && index + length < password.Length)
                    {
                        password = password.Remove(index, length);

                        Console.WriteLine(password);
                    }

                }
                else if (command == "Substitute")
                {
                    string substring = input[1];
                    string substitute = input[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
        }
    }
}
