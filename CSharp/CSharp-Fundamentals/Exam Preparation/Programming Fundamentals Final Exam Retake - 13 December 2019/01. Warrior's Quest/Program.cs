using System;
using System.Linq;

namespace _01._Warrior_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            string skill = Console.ReadLine();

            while (true)
            {

                string inputInfo = Console.ReadLine();

                if (inputInfo == "For Azeroth")
                {
                    break;
                }

                string[] input = inputInfo.Split().ToArray();

                string cmd = input[0];

                if (cmd == "GladiatorStance")
                {
                    skill = skill.ToUpper();

                    Console.WriteLine(skill);
                }
                else if (cmd == "DefensiveStance")
                {
                    skill = skill.ToLower();

                    Console.WriteLine(skill);

                }
                else if (cmd == "Dispel")
                {
                    int index = int.Parse(input[1]);
                    char letter = char.Parse(input[2]);

                    if (index >= 0 && index < skill.Length)
                    {
                        char[] charArray = skill.ToCharArray();
                        charArray[index] = letter;
                        skill = new string(charArray);

                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                }
                else if (cmd == "Target")
                {
                    string cmd2 = input[1];
                    string substring = input[2];

                    if (cmd2 == "Change")
                    {
                        string secondSubstring = input[3];

                        skill = skill.Replace(substring, secondSubstring);

                        Console.WriteLine(skill);
                    }
                    else if (cmd2 == "Remove")
                    {
                        int index = skill.IndexOf(substring);
                        int length = substring.Length;

                        skill = skill.Remove(index, length);

                        Console.WriteLine(skill);
                    }
                    else
                    {
                        Console.WriteLine("Command doesn't exist!");
                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
            }
        }
    }
}
