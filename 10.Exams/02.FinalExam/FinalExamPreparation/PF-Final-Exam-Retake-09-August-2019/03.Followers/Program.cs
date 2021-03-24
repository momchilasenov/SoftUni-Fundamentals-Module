using System;
using System.Linq;
using System.Collections.Generic;


namespace _03.Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Follower> followers = new Dictionary<string, Follower>();

            while (input != "Log out")
            {
                string[] commands = input.Split(": ");
                string command = commands[0];
                string username = commands[1];

                if (command.Contains("New"))
                {
                    if (!followers.ContainsKey(username))
                    {
                        followers.Add(username, new Follower() { Likes = 0, Comments = 0 });
                    }
                }
                else if (command == "Like")
                {
                    int count = int.Parse(commands[2]);
                    if (!followers.ContainsKey(username))
                    {
                        followers.Add(username, new Follower() { Likes = count, Comments = 0 });
                    }
                    else if (followers.ContainsKey(username))
                    {
                        followers[username].Likes += count;
                    }
                }
                else if (command == "Comment")
                {
                    if (!followers.ContainsKey(username))
                    {
                        followers.Add(username, new Follower() { Likes = 0, Comments = 1 });
                    }
                    else if (followers.ContainsKey(username))
                    {
                        followers[username].Comments++;
                    }
                }
                else if (command == "Blocked")
                {
                    if (!followers.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                    else
                    {
                        followers.Remove(username);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{followers.Count} followers");

            var sorted = followers
                .OrderByDescending(x => x.Value.Likes)
                .ThenBy(n => n.Key)
                .ToList();

            foreach (var follower in sorted)
            {
                Console.WriteLine($"{follower.Key}: {follower.Value.Total}");
            }

        }
    }

    public class Follower
    {
        public int Likes { get; set; }
        public int Comments { get; set; }
        public int Total => this.Likes + this.Comments;
    }
}
