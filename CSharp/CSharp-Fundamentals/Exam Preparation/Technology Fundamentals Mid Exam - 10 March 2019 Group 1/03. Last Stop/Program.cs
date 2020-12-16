using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> paintingNo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];

                if (command == "END")
                {
                    Console.WriteLine(string.Join(" ", paintingNo));
                    break;
                }

                if (command == "Change")
                {
                    int number = int.Parse(input[1]);
                    int newNumber = int.Parse(input[2]);

                    if (paintingNo.Contains(number))
                    {
                        int index = paintingNo.IndexOf(number);
                        paintingNo[index] = newNumber;
                    }
                }
                else if (command == "Hide")
                {
                    int number = int.Parse(input[1]);

                    if (paintingNo.Contains(number))
                    {
                        paintingNo.Remove(number);
                    }
                }
                else if (command == "Switch")
                {
                    int number1 = int.Parse(input[1]);
                    int number2 = int.Parse(input[2]);

                    if (paintingNo.Contains(number1) && paintingNo.Contains(number2))
                    {
                        int index1 = paintingNo.IndexOf(number1);
                        int index2 = paintingNo.IndexOf(number2);

                        int temp = paintingNo[index1];
                        paintingNo[index1] = paintingNo[index2];
                        paintingNo[index2] = temp;
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(input[1]) + 1;
                    int number = int.Parse(input[2]);

                    if (index >= 0 && index < paintingNo.Count)
                    {
                        paintingNo.Insert(index, number);
                    }
                }
                else if (command == "Reverse")
                {
                    paintingNo.Reverse();
                }
            }
        }
    }
}
