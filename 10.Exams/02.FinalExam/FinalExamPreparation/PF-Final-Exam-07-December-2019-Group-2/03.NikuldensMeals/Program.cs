using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.NikuldensMeals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
            int unlikedMeals = 0;

            while (input != "Stop")
            {
                string[] commands = input.Split('-', StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];
                string guest = commands[1];
                string meal = commands[2];

                if (command == "Like")
                {
                    if (!guests.ContainsKey(guest))
                    {
                        guests.Add(guest, new List<string>() { meal });
                    }
                    else
                    {
                        if (guests[guest].Contains(meal))
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            guests[guest].Add(meal);

                        }
                    }
                }
                else if (command == "Unlike")
                {
                    if (!guests.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else if (!guests[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                    else
                    {
                        unlikedMeals++;
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                        guests[guest].Remove(meal);
                    }
                }

                input = Console.ReadLine();
            }

            var sorted = guests
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(n => n.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var (name, meal) in guests)
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ",guest.Value)}");
            }
            Console.WriteLine($"Unliked meals: {unlikedMeals}");
        }
    }
}
