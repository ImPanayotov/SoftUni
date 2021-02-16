using System;

namespace _18._Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            // (sbyte < byte < short < ushort < int < uint < long).
            string input = Console.ReadLine();
            bool isSbyte = sbyte.TryParse(input, out sbyte sbyteResult);
            bool isByte = byte.TryParse(input, out byte byteResult);
            
            Console.WriteLine($"{input} can fit in:");  
            
            if (isSbyte && sbyteResult < 0)
            {
                Console.WriteLine($"* sbyte");
                Console.WriteLine($"* short");
                Console.WriteLine($"* int");
                Console.WriteLine($"* long");
            }
            else if (isSbyte && sbyteResult >= 0)
            {
                Console.WriteLine($"* sbyte");
                Console.WriteLine($"* byte");
                Console.WriteLine($"* short");
                Console.WriteLine($"* ushort");
                Console.WriteLine($"* int");
                Console.WriteLine($"* uint");
                Console.WriteLine($"* long");
            }
            else if (true)
            {

            }
        }
    }
}
