using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, City> cities = new Dictionary<string, City>();

            while (input != "Sail")
            {
                string[] cityData = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string name = cityData[0];
                int population = int.Parse(cityData[1]);
                int gold = int.Parse(cityData[2]);

                if (cities.ContainsKey(name))
                {
                    cities[name].Population += population;
                    cities[name].Gold += gold;
                }
                else
                {
                    City city = new City() { Population = population, Gold = gold };
                    cities.Add(name, city);
                }

                input = Console.ReadLine();
            }

            string token = Console.ReadLine();

            while (token != "End")
            {
                string[] commands = token.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];

                if (command == "Plunder")
                {
                    string town = commands[1];
                    int people = int.Parse(commands[2]);
                    int gold = int.Parse(commands[3]);
                    string currentTown = town;

                    int currentPopulation = cities[town].Population;
                    int currentGold = cities[town].Gold;


                    if (currentPopulation - people >= 0 || currentGold - gold >= 0)
                    {
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    }

                    if (currentPopulation - people <= 0 || currentGold - gold <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        cities.Remove(town);
                        token = Console.ReadLine();
                        continue;
                    }

                    cities[currentTown].Population -= people;
                    cities[currentTown].Gold -= gold;

                }

                else if (command == "Prosper")
                {
                    string town = commands[1];
                    int gold = int.Parse(commands[2]);
                    if (gold < 0)  // what if it's == 0
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[town].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town].Gold} gold.");
                    }
                }

                token = Console.ReadLine();
            }

            if (cities.Count > 0)
            {
                cities = cities
                    .OrderByDescending(g => g.Value.Gold)
                    .ThenBy(n => n.Key)
                    .ToDictionary(a => a.Key, b => b.Value);

                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }
    }

    public class City
    {
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
