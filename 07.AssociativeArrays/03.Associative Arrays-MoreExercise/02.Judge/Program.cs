using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests 
                = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "no more time")
            {
                string[] commands = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string username = commands[0];
                string contest = commands[1];
                int points = int.Parse(commands[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>());
                    contests[contest].Add(username, points);
                }
                else if (contests.ContainsKey(contest))
                {
                    if (!contests[contest].ContainsKey(username))
                    {
                        contests[contest].Add(username, points);
                    }
                    else if (contests[contest].ContainsKey(username))
                    {
                        if (contests[contest][username] < points)
                        {
                            contests[contest][username] = points;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var key1 in contests.Keys)
            {
                int participants = contests[key1].Values.Count;
                Console.WriteLine($"{key1}: {participants} participants");

                var value1 = contests[key1];

                value1 = value1
                    .OrderByDescending(x => x.Value)
                    .ThenBy(n => n.Key)
                    .ToDictionary(a => a.Key, b => b.Value);

                int counter = 0;

                foreach (var key2 in value1.Keys)
                {
                    counter++;
                    int points = contests[key1][key2];
                    Console.WriteLine($"{counter}. {key2} <::> {points}");
                }
            }

            Dictionary<string, int> users = new Dictionary<string, int>();

            Console.WriteLine($"Individual standings:");
            //int counter = 0;
            foreach (var key1 in contests.Keys)
            {
                var value1 = contests[key1];
                foreach (var key2 in value1.Keys)
                {
                    if (!users.ContainsKey(key2))
                    {
                        users.Add(key2, contests[key1][key2]);
                    }
                    else
                    {
                        users[key2] += contests[key1][key2];
                    }
                }
            }

            users = users
                .OrderByDescending(x => x.Value)
                .ThenBy(n => n.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            int usersCount = 0;

            foreach (var (user,points) in users)
            {
                usersCount++;

                Console.WriteLine($"{usersCount}. {user} -> {points}");
            }


        }
    }
}
