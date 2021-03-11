using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;


namespace More_Exercises_2._Rage_Quit___Hash_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([\D]+)([\d]+)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            StringBuilder result = new StringBuilder();

            HashSet<char> uniqueSymbols = new HashSet<char>();

            foreach (Match item in matches)
            {
                string symbols = item.Groups[1].Value.ToUpper();
                int number = int.Parse(item.Groups[2].Value);

                if (number > 0)
                {
                    foreach (char symbol in symbols)
                    {
                        uniqueSymbols.Add(symbol);
                    }
                }

                result.Insert(result.Length, symbols, number);
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            Console.WriteLine(result.ToString());
        }
    }
}
