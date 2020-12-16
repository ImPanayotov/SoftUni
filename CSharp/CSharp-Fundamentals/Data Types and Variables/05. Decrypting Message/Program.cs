using System;
using System.Linq;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[] symbols = new char[n];

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                symbols[i] = input;
                symbols[i] += (char)key;
            }
            foreach (char symbol in symbols)
            {
                Console.Write(symbol);
            }
            // You will receive a key(integer) and n characters afterward. 
            // Add the key to each of the characters and append them to a message. 
            // At the end print the message, which you decrypted. 

            //Input
            //•	On the first line, you will receive the key
            //•	On the second line, you will receive n – the number of lines, which will follow
            //•	On the next n lines – you will receive lower and uppercase characters from the Latin alphabet

            //Output
            //Print the decrypted message.
            //Constraints
            //•	The key will be in the interval[0…20]
            //•	n will be in the interval[1…20]
            //•	The characters will always be upper or lower-case letters from the English alphabet
            //•	You will receive one letter per line
            //3
            //7
            //P
            //l
            //c
            //q
            //R
            //k
            //f


        }
    }
}
