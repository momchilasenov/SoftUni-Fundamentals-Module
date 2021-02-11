using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Anonymous_Threat__own__
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] commands = input.Split();
                string command = commands[0];

                if (command == "merge") // abc, def, ghi
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    string mergedWord = string.Empty;

                    if (startIndex < 0)
                    {
                        if (endIndex < words.Count)
                        {
                            startIndex = 0;
                        }
                    }
                    if (endIndex >= words.Count)
                    {
                        if (startIndex >= 0)
                        {
                            endIndex = words.Count - 1;
                        }
                    }

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        mergedWord += words[i];
                    }
                    words.RemoveRange(startIndex, endIndex - startIndex - 1);
                    words.Insert(startIndex, mergedWord);
                }
                else if (command == "divide")
                {
                    int divide = int.Parse(commands[1]);
                    int partitions = int.Parse(commands[2]);
                }
            }
            Console.WriteLine(String.Join(' ', words));
        }
    }
}
