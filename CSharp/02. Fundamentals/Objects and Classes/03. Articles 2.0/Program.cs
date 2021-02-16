using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Article> list = new List<Article>();

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");

                Article myArticle = new Article(tokens[0], tokens[1], tokens [2]);
                list.Add(myArticle);
            }

            string criteria = Console.ReadLine();

            List<Article> sortedArticles = new List<Article>();

            if (criteria == "title")
            {
            sortedArticles =  list.OrderBy(a => a.Title).ToList();
            }
            else if (criteria == "author")
            {
                sortedArticles = list.OrderBy(a => a.Author).ToList();
            }
            else
            {
                sortedArticles = list.OrderBy(a => a.Content).ToList();
            }

            sortedArticles.ForEach(x => Console.WriteLine(x));        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }

    }
}
