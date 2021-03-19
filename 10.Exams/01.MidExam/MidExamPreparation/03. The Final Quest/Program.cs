using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> message = Console.ReadLine()
                .Split()
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commands = input.Split().ToArray();
                string command = commands[0];

                if (command == "Delete")
                {
                    int index = int.Parse(commands[1]);
                    if (index + 1 >= 0 && index + 1 < message.Count)
                    {
                        message.RemoveAt(index + 1);
                    }
                }
                else if (command == "Swap")
                {
                    string word1 = commands[1];
                    string word2 = commands[2];

                    if (message.Contains(word1) && message.Contains(word2))
                    {
                        int firstIndex = message.IndexOf(word1);
                        int secondIndex = message.IndexOf(word2);

                        string temp = message[firstIndex];
                        message[firstIndex] = message[secondIndex];
                        message[secondIndex] = temp;
                    }
                }
                else if (command == "Put")
                {
                    string word = commands[1];
                    int index = int.Parse(commands[2]);
                    if (index - 1 >= 0 && index - 1 <= message.Count)
                    {
                        message.Insert(index - 1, word);
                    }
                }
                else if (command == "Sort")
                {
                    message = message.OrderByDescending(x => x).ToList();
                }
                else if (command == "Replace")
                {
                    string word1 = commands[1];
                    string word2 = commands[2];

                    if (message.Contains(word2))
                    {
                        int index = message.IndexOf(word2);
                        message[index] = word1;
                    }
                }
            }
            Console.WriteLine(String.Join(' ', message));
        }
    }
}
