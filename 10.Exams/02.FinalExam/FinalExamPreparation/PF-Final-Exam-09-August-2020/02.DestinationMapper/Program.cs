using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int travelPoints = 0;

            string pattern = @"(=|\/)([A-Z][A-Za-z]{2,})\1";

            List<string> destinations = new List<string>();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match location in matches)
            {
                travelPoints += location.Groups[2].Value.Length;
                destinations.Add(location.Groups[2].Value);
            }
            Console.Write("Destinations: ");
            Console.WriteLine(string.Join(", ", destinations));
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
