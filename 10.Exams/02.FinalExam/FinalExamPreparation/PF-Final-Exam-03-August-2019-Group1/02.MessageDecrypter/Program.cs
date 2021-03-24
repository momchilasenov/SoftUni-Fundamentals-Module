using System;
using System.Text.RegularExpressions;


namespace _02.MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 

            string pattern = @"^(\$|%)([A-Z][a-z]{2,})\1: \[(\d+)]\|\[(\d+)\]\|\[(\d+)\]\|$";

            for (int i = 0; i < n; i++) 
            {
                string message = Console.ReadLine();

                Match match = Regex.Match(message, pattern);

                if (match.Success)
                {
                    //1ST OPTION
                    //char first = (char)(int.Parse(match.Groups[3].Value));
                    //char second = (char)(int.Parse(match.Groups[4].Value));
                    //char third = (char)(int.Parse(match.Groups[5].Value));

                    //string decrypted = first.ToString() + second.ToString() + third.ToString();
                    //string tag = match.Groups[2].Value;
                    //Console.WriteLine($"{tag}: {decrypted}");

                    //2nd option
                    string tag = match.Groups[2].Value;
                    string decrypted = string.Empty;
                    for (int j = 3; j < match.Groups.Count; j++)
                    {
                        int currentMatch = int.Parse(match.Groups[j].Value);
                        decrypted += (char)currentMatch;
                    }
                    Console.WriteLine($"{tag}: {decrypted}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
