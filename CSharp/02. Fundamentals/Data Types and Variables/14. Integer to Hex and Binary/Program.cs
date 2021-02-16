using System;

namespace _14._Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNum = int.Parse(Console.ReadLine());
            string hexadecimal = decimalNum.ToString("X");
            Console.WriteLine(hexadecimal);
            string binary = Convert.ToString(decimalNum, 2);
            Console.WriteLine(binary);
        }
    }
}
