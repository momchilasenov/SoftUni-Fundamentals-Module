using System;

namespace _01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string token = Console.ReadLine();

            while (token != "Travel")
            {
                string[] commands = token.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];

                if (command.Contains("Add"))
                {
                    int index = int.Parse(commands[1]);
                    string substring = commands[2];

                    if (index >= 0 && index < text.Length)
                    {
                        text = text.Insert(index, substring);
                    }
                }
                else if (command.Contains("Remove"))
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    if (startIndex>=0 && startIndex<text.Length &&
                        endIndex >= 0 && endIndex < text.Length)
                    {
                        text = text.Remove(startIndex, endIndex - startIndex + 1);
                    }

                }
                else if (command.Contains("Switch"))
                {
                    string oldString = commands[1];
                    string newString = commands[2];

                    if (text.Contains(oldString))
                    {
                        text = text.Replace(oldString, newString);
                    }
                }

                Console.WriteLine(text);
                token = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }
    }
}
