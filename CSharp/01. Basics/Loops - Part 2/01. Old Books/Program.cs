using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            // name of the book and number of books in the library
            string bookName = Console.ReadLine();
            int allBooks = int.Parse(Console.ReadLine());

            int searches = 0;

            // main loop for searching the book
            while (true)
            {
                string foundit = Console.ReadLine();
                searches++;

                if (foundit == bookName)
                {
                    Console.WriteLine($"You checked {searches - 1} books and found it.");
                    break;
                }
                else if (searches == allBooks)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {searches} books.");
                    break;
                }
            }

            // output the result


        }
    }
}
