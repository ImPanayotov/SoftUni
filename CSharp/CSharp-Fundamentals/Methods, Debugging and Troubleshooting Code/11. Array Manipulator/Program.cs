using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int min = int.MinValue;
            int max = int.MaxValue;
            if (arr.Length <= 50 && arr.Length >= 1)
            {
                bool isPositive = false;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] >= 0 && arr[i] <= 1000)
                    {
                        isPositive = true;
                    }
                    else
                    {
                        return;
                    }
                }
                if (isPositive)
                {
                    while (true)
                    {
                        string[] input = Console.ReadLine().Split().ToArray();
                        if (input[0] == "end")
                        {
                            Console.WriteLine("[" + string.Join(", ", arr) + "]");
                            break;
                        }

                        if (input[0] == "exchange")
                        {
                            if (int.Parse(input[1]) < 0 || int.Parse(input[1]) >= arr.Length)
                            {
                                Console.WriteLine("Invalid index");
                                continue;
                            }
                            else
                            {
                                Exchange(arr, (int.Parse(input[1])));
                            }
                        }
                        else if (input[0] == "max" && input[1] == "even")
                        {
                            GetMaxEven(arr);
                        }
                        else if (input[0] == "max" && input[1] == "odd") { GetMaxOdd(arr); }
                        else if (input[0] == "min" && input[1] == "even") { GetMinEven(arr); }
                        else if (input[0] == "min" && input[1] == "odd") { GetMinOdd(arr); }

                        else if (input[0] == "first" && input[2] == "even")
                        {
                            if ((int.Parse(input[1]) > arr.Length) || int.Parse(input[1]) <= 0)
                            {
                                Console.WriteLine("Invalid count");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine(GetFirstEven(arr, (int.Parse(input[1]))));
                            }
                        }

                        else if (input[0] == "first" && input[2] == "odd")
                        {
                            if ((int.Parse(input[1]) > arr.Length) || int.Parse(input[1]) <= 0)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                Console.WriteLine(GetFirstOdd(arr, (int.Parse(input[1]))));
                            }
                        }

                        else if (input[0] == "last" && input[2] == "even")
                        {
                            if (int.Parse(input[1]) > arr.Length || int.Parse(input[1]) <= 0)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                Console.WriteLine(GetLastEven(arr, (int.Parse(input[1]))));
                            }
                        }

                        else if (input[0] == "last" && input[2] == "odd")
                        {
                            if (int.Parse(input[1]) > arr.Length || int.Parse(input[1]) <= 0)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                Console.WriteLine(GetLastOdd(arr, (int.Parse(input[1]))));
                            }
                        }

                    }
                }
            }
        }
        public static void Exchange(int[] arr, int n)
        {
            //	exchange { index} – splits the array after the given index, and exchanges the places of the two resulting sub - arrays.
            //  E.g. [1, 2, 3, 4, 5] -> exchange 2 -> result: [4, 5, 1, 2, 3]
            //  If the index is outside the boundaries of the array, print "Invalid index"
            //if (n > arr.Length || n < 0) // or arr.Length - 1!!!
            //{
            //    Console.WriteLine("Invalid index");
            //}
            //else
            //{
            //    int rotation = n + 1;
            //    for (int i = 0; i < rotation; i++)
            //    {
            //        int firstNumber = arr[0];
            //        for (int j = 0; j < arr.Length - 1; j++)
            //        {
            //            arr[j] = arr[j + 1];
            //        }
            //        arr[arr.Length - 1] = firstNumber;
            //    }
            //}
            ////Console.WriteLine("["+string.Join(", ", arr)+"]");
            //return arr;
            int[] temp = new int[n + 1];

            Array.Copy(arr, temp, n + 1);

            int currentIndex = 0;
            for (int i = n + 1; i < arr.Length; i++)
            {
                arr[currentIndex] = arr[i];
                currentIndex++;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                arr[currentIndex] = temp[i];
                currentIndex++;

            }
        }
        public static void GetMaxOdd(int[] arr)
        {
            int oddNum = -1;
            int oddNumValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    if (arr[i] >= oddNumValue)
                    {
                        oddNum = i;
                        oddNumValue = arr[i];

                    }
                }
            }
            if (oddNum == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(oddNum);
            }
        }
        public static void GetMaxEven(int[] arr)
        {

            int evenNum = -1;
            int evenNumValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] >= evenNumValue)
                    {
                        evenNum = i;
                        evenNumValue = arr[i];
                    }
                }
            }
            if (evenNum == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(evenNum);
            }
        }
        public static void GetMinOdd(int[] arr)
        {
            int oddNum = -1;
            int oddNumValue = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    if (arr[i] <= oddNumValue)
                    {
                        oddNum = i;
                        oddNumValue = arr[i];
                    }
                }
            }
            if (oddNum == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(oddNum);
            }
        }
        public static void GetMinEven(int[] arr)
        {
            int evenNum = -1;
            int evenNumValue = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i] <= evenNumValue)
                    {
                        evenNum = i;
                        evenNumValue = arr[i];
                    }
                }
            }
            if (evenNum == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(evenNum);
            }
        }
        public static string GetFirstEven(int[] arr, int n)
        {
            //first {count} even/odd– returns the first {count} elements -> [1, 8, 2, 3] -> first 2 even -> print [8, 2]
            //If the count is greater than the array length, print "Invalid count"
            //If there are not enough elements to satisfy the count, print as many as you can.
            //If there are zero even / odd elements, print an empty array " []"

            int count = 0;
            List<int> evenArr = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr.Add(arr[i]);
                }
            }
            if (evenArr.Count > n)
            {
                evenArr.RemoveRange(n, evenArr.Count - n);
            }

            string result = "[" + string.Join(", ", evenArr) + "]";
            return result;
        }
        public static string GetFirstOdd(int[] arr, int n)
        {
            //first {count} even/odd– returns the first {count} elements -> [1, 8, 2, 3] -> first 2 even -> print [8, 2]
            //If the count is greater than the array length, print "Invalid count"
            //If there are not enough elements to satisfy the count, print as many as you can.
            //If there are zero even / odd elements, print an empty array " []"

            int count = 0;
            List<int> oddArr = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        oddArr.Add(arr[i]);
                    }
                }
                if (oddArr.Count > n)
                {
                    oddArr.RemoveRange(n, oddArr.Count - n);
                }
            }



            string result = "[" + string.Join(", ", oddArr) + "]";
            return result;
        }
        public static string GetLastEven(int[] arr, int n)
        {
            //•	last {count} even/odd – returns the last {count} elements -> [1, 8, 2, 3] -> last 2 odd -> print [1, 3]
            //o If the count is greater than the array length, print "Invalid count"
            //o If there are not enough elements to satisfy the count, print as many as you can.If there are zero even/odd elements, print an empty array " []"
            int count = 0;
            List<int> evenArr = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            if (count <= n)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        evenArr.Add(arr[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        evenArr.Add(arr[i]);

                    }
                }
                evenArr.RemoveRange(0, count - n);
            }
            string result = "[" + string.Join(", ", evenArr) + "]";
            return result;
        }
        public static string GetLastOdd(int[] arr, int n)
        {
            //•	last {count} even/odd – returns the last {count} elements -> [1, 8, 2, 3] -> last 2 odd -> print [1, 3]
            //o If the count is greater than the array length, print "Invalid count"
            //o If there are not enough elements to satisfy the count, print as many as you can.If there are zero even/odd elements, print an empty array " []"
            int count = 0;
            List<int> oddArr = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count++;
                }
            }
            if (count <= n)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        oddArr.Add(arr[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        oddArr.Add(arr[i]);

                    }
                }
                oddArr.RemoveRange(0, count - n);
            }
            string result = "[" + string.Join(", ", oddArr) + "]";
            return result;
        }
    }
}
