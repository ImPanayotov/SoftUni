using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstNum = Console.ReadLine()
                .ToCharArray();

            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();

            int remainder = 0;

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                char currentCh = firstNum[i];
                int currentNumber = 
                    int.Parse(currentCh.ToString());

                int sum = (currentNumber * multiplier) + remainder;
                sb.Append(sum % 10);
                remainder = sum / 10;
            }

            if (remainder != 0)
            {
                sb.Append(remainder);
            }

            List<char> resultArr = sb
                .ToString()
                .Reverse()
                .ToList();

            RemovetrailingZeroes(resultArr);

            Console.WriteLine(String.Join("", resultArr));
        }

        private static void RemovetrailingZeroes(List<char> resultArr)
        {
            if (resultArr[0] == '0')
            {
                int zeroesCount = 0;

                for (int j = 1; j < resultArr.Count; j++)
                {
                    if (resultArr[j] != '0')
                    {
                        zeroesCount = j;
                    }
                }

                for (int i = 0; i < zeroesCount; i++)
                {
                    resultArr.RemoveAt(0);
                }
            }
        }
    }
}
