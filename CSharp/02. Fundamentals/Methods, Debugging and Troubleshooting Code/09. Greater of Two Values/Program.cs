using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            Console.WriteLine(GetMax(type, line1, line2));
        }

        private static string GetMax(string type, string line1, string line2)
        {
            string result = string.Empty;
            if (type == "int")
            {
                int int1 = int.Parse(line1);
                int int2 = int.Parse(line2);
                if (int1 > int2)
                {
                    result = line1;
                }
                else
                {
                    result = line2;
                }
            }
            else if (type == "char")
            {
                char char1 = char.Parse(line1);
                char char2 = char.Parse(line2);
                if (char1 > char2)
                {
                    result = line1;
                }
                else
                {
                    result = line2;
                }
            }
            else if (type == "string")
            {
                int line1Comparison = line1.CompareTo(line2);
                if (line1Comparison > 0)
                {
                    result = line1;
                }
                else
                {
                    result = line2;
                }
                //char[] charArr1 = line1.ToCharArray();
                //char[] charArr2 = line2.ToCharArray();
                //int sum1 = 0;
                //int sum2 = 0;
                //for (int i = 0; i < charArr1.Length; i++)
                //{
                //    charArr1[i] = line1[i];
                //    sum1 += charArr1[i];
                //}
                //for (int i = 0; i < charArr2.Length; i++)
                //{
                //    charArr2[i] = line2[i];
                //    sum2 += charArr2[i];
                //}
                //if (sum1 > sum2)
                //{
                //    result = line1;
                //}
                //else
                //{
                //    result = line2;
                //}
            }
            return result;
        }
    }
}
