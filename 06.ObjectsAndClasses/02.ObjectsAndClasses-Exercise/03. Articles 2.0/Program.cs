using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 1; i <= numberOfArticles; i++)
            {
                string[] articleData = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string title = articleData[0];
                string content = articleData[1];
                string author = articleData[2];

                Article currentArticle = new Article(title, content, author);

                articles.Add(currentArticle);
            }

            string sortBy = Console.ReadLine();
            
            if (sortBy == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            else if (sortBy == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            else if (sortBy == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }

            Console.WriteLine(String.Join(Environment.NewLine, articles));
        }
    }

    public class Article
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
            return $"{Title} - {Content}: {Author}";
        }

    }
}
