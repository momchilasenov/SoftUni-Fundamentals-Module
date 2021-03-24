using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"!([A-Z]{1}[a-z]{2,})!:\[([A-Za-z]{8,})\]";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string command = match.Groups[1].Value;
                    string message = match.Groups[2].Value;

                    int[] encrypted = message.Select(x => (int)x).ToArray();

                    Console.Write($"{ command}: ");
                    Console.WriteLine(string.Join(' ', encrypted));

                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }

            }

            
        }
    }
}
