using System;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string token = Console.ReadLine();
            while (token != "End")
            {
                string[] commands = token.Split();
                string command = commands[0];

                if (command == "Translate")
                {
                    string chr = commands[1];
                    string replacement = commands[2];

                    text = text.Replace(chr, replacement);
                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    string substring = commands[1];
                    if (text.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Start")
                {
                    string substring = commands[1];
                    if (text.StartsWith(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    string chr = commands[1];
                    int index = text.LastIndexOf(chr);
                    Console.WriteLine(index);
                }
                else if (command == "Remove")
                {
                    int startIndex = int.Parse(commands[1]);
                    int count = int.Parse(commands[2]);
                    text = text.Remove(startIndex, count);
                    Console.WriteLine(text);
                }

                token = Console.ReadLine();
            }
        }
    }
}
