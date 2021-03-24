using System;
using System.Linq;
using System.Collections.Generic;


namespace _03.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            for (int i = 0; i < n; i++)
            {
                string token = Console.ReadLine();
                string[] plantData = token.Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plant = plantData[0];
                double rarity = int.Parse(plantData[1]);

                if (!plants.ContainsKey(plant))
                {
                    plants.Add(plant, new Plant() { Rarity = rarity, RatingCount = 0 });

                }
                else
                {
                    plants[plant].Rarity = rarity;
                }

            }

            string input = Console.ReadLine();

            while (input != "Exhibition")
            {
                string[] commands = input.Split(new char[] { ':', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0].Trim();
                string plant = commands[1].Trim();

                if (!plants.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    input = Console.ReadLine();
                    continue;
                }

                if (command == "Rate")
                {
                    double rating = double.Parse(commands[2]);
                    plants[plant].Rating += rating;
                    plants[plant].RatingCount++;
                }
                else if (command == "Update")
                {
                    double newRarity = double.Parse(commands[2]);
                    plants[plant].Rarity = newRarity;
                }
                else if (command == "Reset")
                {
                    plants[plant].Rating = 0;
                    plants[plant].RatingCount = 0;
                }

                input = Console.ReadLine();
            }

            foreach (var plant in plants)
            {
                if (plant.Value.RatingCount == 0)
                {
                    plant.Value.AverageRating = 0;
                }
                else
                {
                    plant.Value.AverageRating = plant.Value.Rating / plant.Value.RatingCount;

                }
            }

            plants = plants
                .OrderByDescending(x => x.Value.Rarity)
                .ThenByDescending(y => y.Value.AverageRating)
                .ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants)
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.AverageRating:f2}");
            }

        }
    }

    public class Plant
    {
        public double Rarity { get; set; }

        public double Rating { get; set; }

        public double RatingCount { get; set; }

        public double AverageRating { get; set; }
    }
}
