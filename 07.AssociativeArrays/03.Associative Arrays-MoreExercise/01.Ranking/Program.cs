using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            Dictionary<string, Dictionary<string, int>> users =
                new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            string bestUser = string.Empty;
            int bestPoints = -1;
            int totalPoints = 0;

            while (input != "end of contests")
            {
                string[] contestData = input.Split(':');
                string contest = contestData[0];
                string password = contestData[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, password);
                }

                input = Console.ReadLine();
            }

            string token = Console.ReadLine();

            while (token != "end of submissions")
            {
                string[] arguments = token.Split("=>");
                string contest = arguments[0];
                string password = arguments[1];
                string username = arguments[2];
                int points = int.Parse(arguments[3]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest] == password)
                    {
                        if (users.ContainsKey(username) && users[username].ContainsKey(contest))
                        {
                            int currentPoints = users[username][contest];

                            if (currentPoints < points)
                            {
                                users[username][contest] = points;
                            }
                        }
                        else if (users.ContainsKey(username) && !users[username].ContainsKey(contest))
                        {
                            users[username].Add(contest, points);
                        }
                        else if (!users.ContainsKey(username))
                        {
                            users.Add(username, new Dictionary<string, int>());
                            users[username].Add(contest, points);
                        }
                    }
                }

                token = Console.ReadLine();
            }

            foreach (var user in users.Keys)
            {
                var userKey = users[user];
                totalPoints = userKey.Sum(x => x.Value);
                if (totalPoints > bestPoints)
                {
                    bestPoints = totalPoints;
                    bestUser = user;
                }
            }

            Console.WriteLine($"Best candidate is {bestUser} with total {bestPoints} points.");

            users = users.OrderBy(n => n.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine("Ranking:");

            foreach (var usersKey in users.Keys)
            {
                Console.WriteLine(usersKey);
                var usersValue = users[usersKey];

                usersValue = usersValue
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(a => a.Key, b => b.Value);

                foreach (var contestKey in usersValue.Keys)
                {
                    int currentPoints = usersValue[contestKey];
                    Console.WriteLine($"#  {contestKey} -> {currentPoints}");
                }
            }
            foreach (var key1 in dict.Keys) //iterate by outer dict keys
            {
                Console.WriteLine(key1);
                var value1 = dict[key1]; //grab the inner dict 
                foreach (var key2 in value1.Keys) //iterate the keys of inner dict
                {
                    string currValue = value1[key2]; //key2 is the key, currValue is value
                    Console.WriteLine($"{key2} -> {currValue}");
                }
            }
        }
    }
}
