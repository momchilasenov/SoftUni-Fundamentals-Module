using System;

namespace _01.Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Sign up")
            {
                string[] commands = input.Split();
                string command = commands[0];

                if (command == "Case")
                {
                    string subcommand = commands[1];
                    if (subcommand == "lower")
                    {
                        username = username.ToLower();
                    }
                    else if (subcommand == "upper")
                    {
                        username = username.ToUpper();
                    }
                    Console.WriteLine(username);
                }
                else if (command == "Reverse")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    if (startIndex >= 0 && startIndex < username.Length && endIndex >= 0 && endIndex < username.Length)
                    {
                        string substring = username.Substring(startIndex, endIndex - startIndex+1);
                        char[] charArray = substring.ToCharArray();
                        Array.Reverse(charArray);
                        string newString = new string(charArray);
                        Console.WriteLine(newString);
                    }
                }
                else if (command == "Cut")
                {
                    string substring = commands[1];

                    if (username.Contains(substring))
                    {
                        username = username.Remove(username.IndexOf(substring), substring.Length);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {substring}");
                    }
                }
                else if (command == "Replace")
                {
                    string chr = commands[1];
                    string newChar = "*";
                    username = username.Replace(chr, newChar);
                    Console.WriteLine(username);
                }
                else if (command == "Check")
                {
                    string chr = commands[1];
                    if (username.Contains(chr))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {chr}.");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
