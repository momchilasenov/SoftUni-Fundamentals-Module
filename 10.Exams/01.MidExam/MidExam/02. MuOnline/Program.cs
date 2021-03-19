using System;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;

            string[] dungeons = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < dungeons.Length; i++)
            {
                string[] dungeonsInfo = dungeons[i].Split();
                string command = dungeonsInfo[0];
                int number = int.Parse(dungeonsInfo[1]);

                int bestRoom = int.MinValue;
                int bestMonster = int.MinValue;

                if (command == "potion")
                {
                    health += number;//90+30=120
                    if (health > 100)
                    {
                        number = 100 - (health - number);
                        health = 100;
                    }
                    Console.WriteLine($"You healed for {number} hp.");//90
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                {
                    Console.WriteLine($"You found {number} bitcoins.");
                    bitcoins += number;
                }
                else //facing a monster
                {
                    if (number > bestMonster)
                    {
                        bestMonster = number;
                        bestRoom = i + 1;
                    }
                    health -= number;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        return;
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");

        }
    }
}
