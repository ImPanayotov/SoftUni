using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCh = Console.ReadLine();

            int power = 0;

            for (int i = 0; i < inputCh.Length; i++)
            {
                if (power > 0 && inputCh[i] != '>')
                {
                    inputCh = inputCh.Remove(i, 1);
                    power--;
                    i--;
                }
                else if (inputCh[i] == '>')
                {
                    power += int.Parse(inputCh[i + 1].ToString());
                }
            }

            Console.WriteLine(inputCh);
        }
    }
}
