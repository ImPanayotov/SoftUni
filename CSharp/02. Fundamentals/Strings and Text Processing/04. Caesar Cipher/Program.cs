using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                int charValue = Convert.ToInt32(text[i]) + 3;
                text[i] = Convert.ToChar(charValue);
            }

            foreach (var item in text)
            {
                Console.Write(item);
            }
        }
    }
}
