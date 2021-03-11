using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //(?: |^)\+359( |-)2\1\d{3}\1\d{4}\b

            string input = Console.ReadLine();

            Regex regex = new Regex(@"(?: |^)\+359( |-)2\1\d{3}\1\d{4}\b");

            MatchCollection phoneNumbers = regex.Matches(input);

            string[] foundMatches = phoneNumbers
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", foundMatches));
        }
    }
}
