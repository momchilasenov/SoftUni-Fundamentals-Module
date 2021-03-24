using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Complete")
            {
                string[] commands = input.Split();
                string command = commands[0];

                if (command == "Make")
                {
                    string subCommand = commands[1];
                    if (subCommand == "Upper")
                    {
                        email = email.ToUpper();
                    }
                    else if (subCommand == "Lower")
                    {
                        email = email.ToLower();
                    }
                    Console.WriteLine(email);
                }
                else if (command.Contains("Get"))
                {
                    if (command.Contains("Domain"))
                    {
                        int count = int.Parse(commands[1]);
                        int startIndex = email.Length - count;
                        string substring = email.Substring(startIndex);
                        Console.WriteLine(substring);
                    }
                    else
                    {
                        if (!email.Contains('@'))
                        {
                            Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                        }
                        else
                        {
                            int index = email.IndexOf('@');
                            string substring = email.Substring(0, index);
                            Console.WriteLine(substring);
                        }
                    }

                }

                else if (command == "Replace")
                {
                    char letter = char.Parse(commands[1]);
                    email = email.Replace(letter, '-');
                    Console.WriteLine(email);
                }
                else if (command == "Encrypt")
                {
                    int[] chars = email
                        .Select(x => (int)x)
                        .ToArray();
                    Console.WriteLine(string.Join(' ', chars));
                }

                input = Console.ReadLine();

                someString.Split("@", 2);
            }
        }
    }
}
