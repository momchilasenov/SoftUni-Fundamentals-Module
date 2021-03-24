using System;

namespace _01.Nikulden_sCharity
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Finish")
            {
                string[] commands = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];

                if (command == "Replace")
                {
                    string currentChar = commands[1];
                    string newChar = commands[2];
                    message = message.Replace(currentChar, newChar);

                    Console.WriteLine(message);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    if (startIndex >= 0 && startIndex < message.Length && endIndex >= 0 && endIndex < message.Length)
                    {
                        message = message.Remove(startIndex, endIndex - startIndex+1); 
                        Console.WriteLine(message);                                   
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                else if (command == "Make")
                {
                    string subCommand = commands[1];

                    if (subCommand == "Upper")
                    {
                        message = message.ToUpper();
                    }
                    else if (subCommand == "Lower")
                    {
                        message = message.ToLower();
                    }
                    Console.WriteLine(message);
                }
                else if (command == "Check")
                {
                    string text = commands[1];
                    if (message.Contains(text))
                    {
                        Console.WriteLine($"Message contains {text}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {text}");
                    }
                }
                else if (command == "Sum")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    if (startIndex >= 0 && startIndex < message.Length && endIndex >= 0 && endIndex < message.Length)
                    {
                        int totalSum = 0;
                        string substring = message.Substring(startIndex, endIndex - startIndex);
                        foreach (char letter in substring)
                        {
                            totalSum += (int)letter;
                        }
                        Console.WriteLine(totalSum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }

                }

                input = Console.ReadLine();
            }
        }
    }
}
