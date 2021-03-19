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
                .Split('&', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] commands = input.Split('|').ToArray();

                string[] bookCommand = commands[0]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = bookCommand[0];

                if (command == "Add")
                {
                    string book = commands[1].Trim();
                    if (!books.Contains(book))
                    {
                        books.Insert(0, book);
                    }
                }
                else if (command == "Take")
                {
                    string book = commands[1].Trim();
                    if (books.Contains(book))
                    {
                        books.Remove(book);
                    }
                }
                else if (command == "Swap")
                {
                    string firstBook = commands[1].Trim();
                    string secondBook = commands[2].Trim();
                    if (books.Contains(firstBook) && books.Contains(secondBook))
                    {
                        int firstIndex = books.IndexOf(firstBook);
                        int secondIndex = books.IndexOf(secondBook);

                        string temp = books[Math.Max(firstIndex, secondIndex)];
                        books[Math.Max(firstIndex, secondIndex)] = books[Math.Min(firstIndex, secondIndex)];
                        books[Math.Min(firstIndex, secondIndex)] = temp;

                    }
                }
                else if (command == "Insert")
                {
                    string book = commands[1].Trim();
                    books.Add(book);
                }
                else if (command == "Check")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index < books.Count)
                    {
                        Console.WriteLine(books[index]);
                    }
                }

            }
            for (int i = 0; i < books.Count; i++)
            {
                books[i] = books[i].Trim();
            }
            Console.WriteLine(String.Join(", ", books));
        }
    }
}
