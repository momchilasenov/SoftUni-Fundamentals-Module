using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            //  \b\d{2}(\/|-|.)[A-Z]{1}[a-z]{2}\1\d{4}\b

            string input = Console.ReadLine();
            Regex regex = new Regex(@"\b(\d{2})(\/|-|.)([A-Z]{1}[a-z]{2})\2(\d{4})\b");

            MatchCollection matches = regex.Matches(input);

            foreach (Match date in matches)
            {
                Console.WriteLine($"Day: {date.Groups[1]}, Month: {date.Groups[3]}, Year: {date.Groups[4]}");
            }

        }
    }
}
