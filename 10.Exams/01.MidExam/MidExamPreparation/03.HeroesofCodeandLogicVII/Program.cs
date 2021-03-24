using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesofCodeandLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] heroData = input.Split();
                string name = heroData[0];
                int hitPoints = int.Parse(heroData[1]);
                int manaPoints = int.Parse(heroData[2]);

                heroes.Add(name, new List<int>());
                heroes[name].Add(hitPoints);
                heroes[name].Add(manaPoints);
            }

            string request = Console.ReadLine();

            while (request != "End")
            {
                string[] commands = request.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];
                string heroName = commands[1];

                if (heroes.ContainsKey(heroName))
                {
                    if (command == "CastSpell")
                    {
                        int requiredMana = int.Parse(commands[2]);
                        string spellName = commands[3];

                        int currentHeroMana = heroes[heroName][1];
                        if (currentHeroMana >= requiredMana)
                        {
                            heroes[heroName][1] -= requiredMana;
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                    }

                    else if (command == "TakeDamage")
                    {
                        int damage = int.Parse(commands[2]);
                        string attacker = commands[3];

                        int currentHeroAttack = heroes[heroName][0];

                        if (currentHeroAttack > damage)
                        {
                            heroes[heroName][0] -= damage;
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
                        }
                        else
                        {
                            heroes.Remove(heroName);
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        }
                    }

                    else if (command == "Recharge")
                    {
                        int amount = int.Parse(commands[2]);
                        int amountRecovered = 0;

                        if (heroes[heroName][1] + amount > 200)
                        {
                            amountRecovered = 200 - heroes[heroName][1];
                            heroes[heroName][1] = 200;
                        }
                        else
                        {
                            heroes[heroName][1] += amount;
                            amountRecovered = amount;
                        }

                        Console.WriteLine($"{heroName} recharged for {amountRecovered} MP!");

                    }

                    else if (command == "Heal")
                    {
                        int amount = int.Parse(commands[2]);
                        int amountRecovered = 0;

                        if (heroes[heroName][0] + amount > 100)
                        {
                            amountRecovered = 100 - heroes[heroName][0];
                            heroes[heroName][0] = 100;
                        }
                        else
                        {
                            heroes[heroName][0] += amount;
                            amountRecovered = amount;
                        }
                        Console.WriteLine($"{heroName} healed for {amountRecovered} HP!");

                    }
                }
                request = Console.ReadLine();
            }
            heroes = heroes
                .OrderByDescending(p => p.Value[0])
                .ThenBy(n => n.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }
            
        }
    }
}

