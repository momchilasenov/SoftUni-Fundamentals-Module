using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(@|#)([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            Dictionary<int, List<string>> mirrorPairs = new Dictionary<int, List<string>>();
            int uniqueKey = 0;

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");

                foreach (Match word in matches)
                {
                    uniqueKey++;
                    string first = word.Groups[2].Value;
                    string second = word.Groups[3].Value;

                    StringBuilder sb = new StringBuilder();

                    for (int i = first.Length - 1; i >= 0; i--)
                    {
                        sb.Append(first[i]);
                    }
                    first = sb.ToString();

                    if (first == second)
                    {
                        mirrorPairs.Add(uniqueKey, new List<string>() { word.Groups[2].Value, word.Groups[3].Value });
                    }
                }
            }

            if (mirrorPairs.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");

                var pairs = mirrorPairs.Select(kvp => kvp.Value[0] + " <=> " + kvp.Value[1]);
                Console.WriteLine(string.Join(", ", pairs)); 
            }

        }
    }
}
