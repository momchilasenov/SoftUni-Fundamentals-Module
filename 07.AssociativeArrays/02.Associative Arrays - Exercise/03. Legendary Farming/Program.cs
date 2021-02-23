using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLegendary = false;

            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("motes", 0);
            keyMaterials.Add("fragments", 0);

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;

                            Console.WriteLine(material == "shards" 
                                ? "Shadowmourne obtained!" 
                                : material == "fragments" 
                                ? "Valanyr obtained!" 
                                : "Dragonwrath obtained!");

                            isLegendary = true;
                            break;
                        }
                    }
                    else
                    {
                        if (junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] += quantity;
                        }
                        else
                        {
                            junkMaterials.Add(material, quantity);
                        }
                    }
                }

                if (isLegendary)
                {
                    break;
                }

            }

            foreach (var element in keyMaterials.OrderByDescending(n => n.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }
            foreach (var element in junkMaterials.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }

        }
    }
}

