using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> morse = new Dictionary<string, string>();
            morse.Add(".-", "A"); morse.Add("-...", "B"); morse.Add("-.-.", "C"); morse.Add("-..", "D");
            morse.Add(".", "E"); morse.Add("..-.", "F"); morse.Add("--.", "G"); morse.Add("....", "H");
            morse.Add("..", "I"); morse.Add(".---", "J"); morse.Add("-.-", "K"); morse.Add(".-..", "L");
            morse.Add("--", "M"); morse.Add("-.", "N"); morse.Add("---", "O"); morse.Add(".--.", "P");
            morse.Add("--.-", "Q"); morse.Add(".-.", "R"); morse.Add("...", "S"); morse.Add("-", "T");
            morse.Add("..-", "U"); morse.Add("...-", "V"); morse.Add(".--", "W"); morse.Add("-..-", "X");
            morse.Add("-.--", "Y"); morse.Add("--..", "Z");

            string[] words = Console.ReadLine().Split(" | ").ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                string[] letters = words[i].Split().ToArray();

                for (int j = 0; j < letters.Length; j++)
                {
                    if (morse.ContainsKey(letters[j]))
                    {
                        Console.Write(morse[letters[j]]);
                    }
                }
                Console.Write(" ");
            }

        }
    }
}
