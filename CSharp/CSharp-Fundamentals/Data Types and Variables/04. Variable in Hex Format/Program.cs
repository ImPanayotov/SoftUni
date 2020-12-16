using System;

namespace _04._Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            decimal num2 = Convert.ToInt32(num, 16);
            Console.WriteLine(num2);
        }
    }
}
