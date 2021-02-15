using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> articleData = input
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string title = articleData[0]; //some title
            string content = articleData[1];
            string author = articleData[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] requests = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = requests[0];
                string newInput = requests[1];

                //промяна на новосъздадения обект article
                if (command == "Edit")
                {
                    article.Edit(newInput);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(newInput);
                }
                else if (command == "Rename")
                {
                    article.Rename(newInput);
                }
            }
            Console.WriteLine(article.ToString());

        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor (string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename (string newTitle)
        {
            this.Title = newTitle;
        }
       

    }
}
