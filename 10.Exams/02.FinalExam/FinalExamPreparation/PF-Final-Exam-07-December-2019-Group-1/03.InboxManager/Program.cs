using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.InboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            while (input != "Statistics")
            {
                string[] commands = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];
                string user = commands[1];

                if (command == "Add")
                {
                    if (users.ContainsKey(user))
                    {
                        Console.WriteLine($"{user} is already registered");
                    }
                    else
                    {
                        users.Add(user, new List<string>());
                    }
                }
                else if (command == "Send")
                {
                    string email = commands[2];
                    users[user].Add(email);
                }
                else if (command == "Delete")
                {
                    if (users.ContainsKey(user))
                    {
                        users.Remove(user);

                    }
                    else
                    {
                        Console.WriteLine($"{user} not found!");
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Users count: {users.Count}");

            var sorted = users
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(y => y.Key)
                .ToList();
                //alternative .ToDictionary(a => a.Key, b => b.Value);

            foreach(var user in sorted)
            {
                Console.WriteLine(user.Key);
                foreach (var email in user.Value)
                {
                    Console.WriteLine($"- {email}");
                }
                Console.WriteLine(String.Join("\n -", user.));
            }
        }
    }
}
