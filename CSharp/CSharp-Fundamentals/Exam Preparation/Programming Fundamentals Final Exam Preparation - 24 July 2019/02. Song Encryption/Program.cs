using System;
using System.Text.RegularExpressions;

namespace _02._Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new
                Regex(@"^(?<artist>[A-Z][a-z' ]+)[:](?<song>[A-Z ]+)$");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                Match match = regex.Match(input);

                if (!regex.IsMatch(input))
                {
                    Console.WriteLine($"Invalid input!");
                    continue;
                }
                input = input.Replace(':', '@');

                int key = match.Groups["artist"].Value.Length;
                //A-Z - 65-90; a-z - 97-122
                char[] charArray = input.ToCharArray();

                for (int i = 0; i < charArray.Length; i++)
                {
                    if (charArray[i] != '\'' && charArray[i] != ' ' && charArray[i] != '@')
                    {
                        int letter = charArray[i];
                        int newLetter = charArray[i] + key;
                        if (newLetter >= 65 && newLetter <= 90 || newLetter >= 97 && newLetter <= 122)
                        {
                            charArray[i] = (char)(charArray[i] + key);
                        }
                        if (letter >= 65 && letter <= 90 && newLetter > 90)
                        {
                            int newKey = newLetter - 90 - 1;
                            charArray[i] = (char)(65 + newKey);
                        }
                        if (letter >= 97 && letter <= 122 && newLetter > 122)
                        {
                            int newKey = newLetter - 122 - 1;
                            charArray[i] = (char)(97 + newKey);
                        }
                    }
                }

                input = string.Join("", charArray);

                Console.WriteLine($"Successful encryption: {input}");
            }
        }
    }
}
