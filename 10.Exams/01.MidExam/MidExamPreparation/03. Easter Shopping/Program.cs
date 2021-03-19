using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Easter_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                string[] commands = input.Split().ToArray();
                string command = commands[0];

                if (command == "Include")
                {
                    string shop = commands[1];
                    shops.Add(shop);
                }
                else if (command == "Visit")
                {
                    int numberOfShops = int.Parse(commands[2]);

                    if (numberOfShops <= shops.Count)
                    {
                        if (commands[1] == "first")
                        {
                            shops.RemoveRange(0, numberOfShops);
                        }
                        else if (commands[1] == "last")
                        {
                            int startIndex = shops.Count - 1 - numberOfShops;
                            shops.RemoveRange(startIndex + 1, numberOfShops);
                        }
                    }

                }
                else if (command == "Prefer")
                {
                    int firstShopIndex = int.Parse(commands[1]);
                    int secondShopIndex = int.Parse(commands[2]);

                    if (firstShopIndex >= 0
                        && firstShopIndex < shops.Count
                        && secondShopIndex >= 0
                        && secondShopIndex < shops.Count)
                    {
                        string temp = shops[firstShopIndex];
                        shops[firstShopIndex] = shops[secondShopIndex];
                        shops[secondShopIndex] = temp;
                    }
                }
                else if (command == "Place")
                {
                    string shop = commands[1];
                    int shopIndex = int.Parse(commands[2]);
                    if (shopIndex + 1 < shops.Count)
                    {
                        shops.Insert(shopIndex + 1, shop);
                    }
                }
            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(String.Join(' ', shops));
            
        }
    }
}
