using System;
using System.Linq;
using System.Text;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();


            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(">>>")
                    .ToArray();

                string command = input[0];

                if (command == "Generate")
                {
                    Console.WriteLine($"Your activation key is: {activationKey}");
                    break;
                }

                if (command == "Contains")
                {
                    string substring = input[1];

                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string direction = input[1];
                    int start = int.Parse(input[2]);
                    int end = int.Parse(input[3]);

                    if (direction == "Upper")
                    {
                        char[] key = activationKey.ToCharArray();

                        for (int i = start; i < end; i++)
                        {
                            if (char.IsLower(key[i]))
                            {
                                key[i] = char.ToUpper(key[i]);
                            }
                        }

                        activationKey = string.Join("", key);

                        Console.WriteLine(activationKey);
                    }
                    else if (direction == "Lower")//check it!
                    {
                        char[] key = activationKey.ToCharArray();

                        for (int i = start; i < end; i++)
                        {
                            if (char.IsUpper(key[i]))
                            {
                                key[i] = char.ToLower(key[i]);
                            }
                        }

                        activationKey = string.Join("", key);

                        Console.WriteLine(activationKey);
                    }
                }
                else if (command == "Slice")
                {
                    int start = int.Parse(input[1]);
                    int end = int.Parse(input[2]);

                    activationKey = activationKey.Remove(start, end - start);

                    Console.WriteLine(activationKey);
                }
            }
        }
    }
}
