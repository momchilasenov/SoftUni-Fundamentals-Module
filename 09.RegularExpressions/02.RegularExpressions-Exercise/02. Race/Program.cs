using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> racers = Console.ReadLine()
                .Split(", ")
                .ToList();

            string first = string.Empty;
            string second = string.Empty;
            string third = string.Empty;

            Dictionary<string, int> racersDictionary = new Dictionary<string, int>();
            for (int i = 0; i < racers.Count; i++)
            {
                string currentName = racers[i].Trim();
                racersDictionary.Add(currentName, 0);
            }

            string lettersPattern = @"(?<letters>[A-Za-z])";
            string numbersPattern = @"(?<numbers>[0-9])";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = string.Empty;
                int distance = 0;

                Regex lettersRegex = new Regex(lettersPattern);
                Regex numbersRegex = new Regex(numbersPattern);
                MatchCollection lettersMatch = lettersRegex.Matches(input);
                MatchCollection numbersMatch = numbersRegex.Matches(input);

                foreach (Match letter in lettersMatch)
                {
                    name += letter.Value;
                }
                foreach (Match number in numbersMatch)
                {
                    distance += int.Parse(number.Value);
                }

                if (racersDictionary.ContainsKey(name))
                {
                    racersDictionary[name] += distance;
                }
                input = Console.ReadLine();
            }

            //Print the result - 1st option
            //racersDictionary = racersDictionary
            //    .OrderByDescending(r => r.Value)
            //    .ToDictionary(a => a.Key, b => b.Value);

            //var enumerator = racersDictionary.Keys.ToArray();

            //for (int i = 0; i < enumerator.Length; i++)
            //{
            //    first = enumerator[0];
            //    second = enumerator[1];
            //    third = enumerator[2];
            //}
            //Console.WriteLine($"1st place: {first}");
            //Console.WriteLine($"2nd place: {second}");
            //Console.WriteLine($"3rd place: {third}");

            //second option
            List<string> sorted = racersDictionary
                .OrderByDescending(x => x.Value)
                .Select(x => x.Key)
                .ToList();

            Console.WriteLine($"1st place: {sorted[0]}");
            Console.WriteLine($"2nd place: {sorted[1]}");
            Console.WriteLine($"3rd place: {sorted[2]}");

        }
    }
}
