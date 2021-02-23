using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._ForceBook_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceSides = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.IndexOf(" | ") >= 0)
                {
                    string[] command = input.Split('|');
                    string forceSide = command[0].Trim();
                    string forceUser = command[1].Trim();

                    if (forceSides.ContainsKey(forceSide))
                    {
                        forceSides[forceSide].Add(forceUser);
                    }
                    else
                    {
                        forceSides.Add(forceSide, new List<string>());
                        forceSides[forceSide].Add(forceUser);
                    }

                }

                else if (input.Contains('>'))
                {
                    string[] command = input.Split("->");
                    string forceUser = command[0].Trim(); //dcay
                    string forceSide = command[1].Trim(); //lighter

                    bool containsUser = forceSides.Any(x => x.Value.Contains(forceUser));

                    if (containsUser)
                    {
                        string key = forceSides.FirstOrDefault(x => x.Value.Contains(forceUser)).Key;
                        forceSides[key].Remove(forceUser);
                        forceSides[forceSide].Add(forceUser);
                    }
                    else
                    {
                        forceSides[forceSide].Add(forceUser);
                    }
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

            //forceSides = forceSides
            //    .Where(w => w.Value.Count > 0)
            //    .OrderByDescending(x => x.Value.Count)
            //    .ThenBy(y => y.Key)
            //    .ToDictionary(a => a.Key, b => b.Value);

            foreach (var forceSide in forceSides
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(y => y.Key))
            {
                if (forceSide.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {forceSide.Key}, Members: {forceSide.Value.Count}");

                    foreach (string user in forceSide.Value.OrderBy(n => n))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
                    
            }

        }

    }
}

