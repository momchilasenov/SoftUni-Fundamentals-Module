using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"U\$([A-Z][a-z]{2,})U\$P@\$([A-Za-z0-9]{5,}[0-9])P@\$";
            int successCount = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    successCount++;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {match.Groups[1]}, Password: {match.Groups[2]}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {successCount}");
        }
    }
}
