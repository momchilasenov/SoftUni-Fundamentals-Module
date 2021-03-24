using System;
using System.Text.RegularExpressions;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            string pattern = @"^(.+)>(\d{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1$";

            for (int i = 0; i < n; i++)
            {
                string decrypted = string.Empty;
                string password = Console.ReadLine();

                Match match = Regex.Match(password, pattern);

                if (match.Success)
                {
                    for (int j = 2; j < match.Groups.Count; j++)
                    {
                        decrypted += match.Groups[j].Value;
                    }
                    Console.WriteLine($"Password: {decrypted}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
            
        }
    }
}
