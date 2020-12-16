using System;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();

            Console.WriteLine("<h1>" + Environment.NewLine + title + Environment.NewLine + "</h1>");
            Console.WriteLine("<article>" + Environment.NewLine + content + Environment.NewLine + "</article>");

            while (true)
            {
                string comment = Console.ReadLine();

                if (comment == "end of comments")
                {
                    break;
                }

                Console.WriteLine("<div>" + Environment.NewLine + comment + Environment.NewLine + "</div>");
            }
        }
    }
}
