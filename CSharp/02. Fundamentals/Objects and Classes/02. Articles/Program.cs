using System;
using System.Reflection.Metadata.Ecma335;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article myArticle = new Article(input[0], input[1], input[2]);
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                string cmd = command[0];

                if (cmd == "Edit")
                {
                    myArticle.Content = command[1];
                }
                else if (cmd == "ChangeAuthor")
                {
                    myArticle.Change(command[1]);
                }
                else if (cmd == "Rename")
                {
                    myArticle.Rename(command[1]);
                }
                
            }
            Console.WriteLine(myArticle);
        }
    }

    class Article
    {
        public Article (string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }
        
        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string content)
        {
            this.Content = content;
        }

        public void Change(string author)
        {
            this.Author = author;
        }

        public void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }

    }
}
