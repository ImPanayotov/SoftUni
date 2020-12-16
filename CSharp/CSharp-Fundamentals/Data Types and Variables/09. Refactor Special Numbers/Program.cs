using System;

namespace _09._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0; 
            int digit = 0; 
            bool isSpecial = false;
            for (int num = 1; num <= n; num++)
            {
                digit = num;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{digit} -> {isSpecial}");
                sum = 0;
                num = digit;
            }

        }
    }
}
