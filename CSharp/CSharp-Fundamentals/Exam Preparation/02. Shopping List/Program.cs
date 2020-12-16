using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] shoppingList = str.Split("!");
            List<string> list = new List<string>();
            for (int i = 0; i < shoppingList.Length; i++)
            {
                list.Add(shoppingList[i]);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Go Shopping!")
                {
                    break;
                }

                string[] arr = input.Split();

                if (arr[0] == "Urgent")
                {
                    if (list.Contains(arr[1]))
                    {
                        continue;
                    }
                    else
                    {
                        list.Insert(0, arr[1]);
                    }
                }
                else if (arr[0] == "Unnecessary")
                {
                    if (list.Contains(arr[1]))
                    {
                        list.Remove(arr[1]);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (arr[0] == "Correct")
                {
                    if (list.Contains(arr[1]))
                    {
                        int index = list.IndexOf(arr[1]);
                        list.RemoveAt(index);
                        list.Insert(index, arr[2]);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (arr[0] == "Rearrange")
                {
                    if (list.Contains(arr[1]))
                    {
                        list.Remove(arr[1]);
                        list.Add(arr[1]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
