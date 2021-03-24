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

                if (command == "New follower")
                {
                    if (followers.ContainsKey(username)==false)
                    {
                        followers.Add(username, new Follower() { Likes = 0, Comments = 0 });
                    }
                }
                else if (command == "Like")
                {
                    int likes = int.Parse(commands[2]);

                    if (followers.ContainsKey(username)==false)
                    {
                        followers.Add(username, new Follower() { Likes = likes, Comments = 0 });
                    }
                    else if (followers.ContainsKey(username))
                    {
                        followers[username].Likes += likes;
                    }
                }
                else if (command == "Comment")
                {
                    if (followers.ContainsKey(username)==false)
                    {
                        followers.Add(username, new Follower() { Likes = 0, Comments = 1 });
                    }
                    else if (followers.ContainsKey(username))
                    {
                        followers[username].Comments += 1;
                    }
                }
                else if (command == "Blocked")
                {
                    if (followers.ContainsKey(username))
                    {
                        followers.Remove(username);
                    }
                    else if (followers.ContainsKey(username) == false)
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{followers.Count} followers");
            followers.GetValueOrDefault()

            followers = followers
                .OrderByDescending(x => x.Value.LikesAndComments)
                .ThenBy(y => y.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var follower in followers)
            {
                Console.WriteLine($"{follower.Key}: {follower.Value.LikesAndComments}");
            }
        }
    }

    public class Follower
    {
        public int Likes { get; set; }
        public int Comments { get; set; }
        public int LikesAndComments => Likes + Comments;
    }
}
