using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _02Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<Article> articleList = new List<Article>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                var article = new Article(command[0], command[1], command[2]);

                articleList.Add(article);
            }

            string order = Console.ReadLine();

            switch (order)
            {
                case "title":
                    articleList = articleList.OrderBy(X => X.Title).ToList();
                    break;
                case "content":
                    articleList = articleList.OrderBy(X => X.Content).ToList();
                    break;
                case "author":
                    articleList = articleList.OrderBy(X => X.Author).ToList();
                    break;
            }

            Console.WriteLine(string.Join(Environment.NewLine, articleList));
        }

        class Article
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
        }
    }
}
