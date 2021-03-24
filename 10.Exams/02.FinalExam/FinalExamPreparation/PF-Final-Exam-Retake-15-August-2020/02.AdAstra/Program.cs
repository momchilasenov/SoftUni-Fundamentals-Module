using System;
using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\||#)([A-Za-z\s]+)\1(\d{2}\/\d{2}\/\d{2})\1(\d+)\1";

            MatchCollection matches = Regex.Matches(input, pattern);
            int totalCalories = 0;
            int caloriesPerDay = 2000;
            int days = 0;

            foreach (Match match in matches)
            {
                totalCalories += int.Parse(match.Groups[4].Value);
            }
            days = totalCalories / caloriesPerDay;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach(Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups[2].Value}, Best before: {match.Groups[3].Value}, Nutrition: {match.Groups[4].Value}");
            }
        }
    }
}
