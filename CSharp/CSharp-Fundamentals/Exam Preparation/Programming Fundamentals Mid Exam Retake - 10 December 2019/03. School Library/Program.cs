using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine()
                .Split("&")
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = input[0];

                if (command == "Done")
                {
                    Console.WriteLine(string.Join(", ", books));
                    break;
                }

                if (command == "Add Book")
                {
                    string book = input[1];

                    if (!books.Contains(book))
                    {
                        books.Insert(0, book);
                    }
                }
                else if (command == "Take Book")
                {
                    string book = input[1];

                    if (books.Contains(book))
                    {
                        books.Remove(book);
                    }
                }
                else if (command == "Swap Books")
                {
                    string book1 = input[1];
                    string book2 = input[2];

                    if (books.Contains(book1) && books.Contains(book2))
                    {
                        int index1 = books.IndexOf(book1);
                        int index2 = books.IndexOf(book2);
                        string temp = books[index1];
                        books[index1] = books[index2];
                        books[index2] = temp;
                    }
                }
                else if (command == "Insert Book")
                {
                    string book = input[1];
                    books.Add(book);
                }
                else if (command == "Check Book")
                {
                    int index = int.Parse(input[1]);

                    if (index >=0 && index < books.Count)
                    {
                        Console.WriteLine(books[index]);
                    }
                }
            }
        }
    }
}
