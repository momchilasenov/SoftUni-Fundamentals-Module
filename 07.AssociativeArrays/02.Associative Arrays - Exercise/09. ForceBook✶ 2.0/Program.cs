using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._ForceBook__2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> book = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] data = input.Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input.Contains("|"))
                {
                    string side = data[0];
                    string user = data[1];

                    //check if the side has been created
                    if (!book.ContainsKey(side))
                    {
                        book[side] = new List<string>();
                    }
                    //check if the user exists in the entire book
                    if (!book.Values.Any(l => l.Contains(user)))
                    {
                        book[side].Add(user);
                    }

                }
                else if (input.Contains("->"))
                {
                    string user = data[0];
                    string side = data[1];

                    foreach (var kvp in book)
                    {
                        if (kvp.Value.Contains(user))
                        {
                            kvp.Value.Remove(user);
                        }
                    }
                    //check if the side is created
                    if (!book.ContainsKey(side))
                    {
                        book[side] = new List<string>();
                    }

                    book[side].Add(user);
                    Console.WriteLine($"{user} joins the {side} side!");

                }

            }

            Dictionary<string, List<string>> newBook = book
                .Where(kvp => kvp.Value.Count > 0)
                .OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in newBook)
            {
                string side = kvp.Key;
                List<string> users = kvp.Value.OrderBy(u => u).ToList(); //сортиране на листа

                Console.WriteLine($"Side: {side}, Members: {users.Count}");

                foreach (string user in users)
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
