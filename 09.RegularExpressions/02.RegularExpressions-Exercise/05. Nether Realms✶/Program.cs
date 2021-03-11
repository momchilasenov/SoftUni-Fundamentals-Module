using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;

namespace _05._Nether_Realms_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, List<double>> demonDictionary = new Dictionary<string, List<double>>();

            string healthPattern = @"[^\d\+\/\*\.-]";

            for (int i = 0; i < demons.Length; i++)
            {
                double totalHealth = 0;
                double totalDamage = 0;
                string currentDemon = demons[i];

                Regex healthRegex = new Regex(healthPattern);
                MatchCollection matches = healthRegex.Matches(currentDemon);

                foreach (Match symbol in matches)
                {
                    totalHealth += char.Parse(symbol.Value);
                }

                string damagePattern = @"-?\d+\.?\d*";
                string modifyDamage = @"[\/*]";

                Regex damage = new Regex(damagePattern);
                MatchCollection numbers = damage.Matches(currentDemon);

                foreach (Match number in numbers)
                {
                    totalDamage += double.Parse(number.Value);
                }

                Regex modify = new Regex(modifyDamage);
                MatchCollection symbols = modify.Matches(currentDemon);

                foreach (Match symbol in symbols)
                {
                    if (symbol.Value == "*")
                    {
                        totalDamage *= 2;
                    }
                    else if (symbol.Value == "/")
                    {
                        totalDamage /= 2;
                    }
                }
                demonDictionary.Add(currentDemon, new List<double>());
                demonDictionary[currentDemon].Add(totalHealth);
                demonDictionary[currentDemon].Add(totalDamage);
            }

            demonDictionary = demonDictionary
                .OrderBy(n => n.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var demon in demonDictionary)
            {
                string demonName = demon.Key;
                double demonHealth = demon.Value[0];
                double demonDamage = demon.Value[1];

                Console.WriteLine($"{demonName} - {demonHealth} health, {demonDamage:f2} damage");
            }
        }
    }
}
