﻿using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails_
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"((?<=\s)[A-Za-z0-9]+[_\-\.]?[A-Za-z0-9]+)@(([A-Za-z]+-?[A-Za-z]+)[\.][A-Za-z]+([\.][A-Za-z]+)*)";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }
    }
}
