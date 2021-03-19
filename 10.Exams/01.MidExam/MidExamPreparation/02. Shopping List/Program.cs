using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] commands = input
                    .Split()
                    .ToArray();

                string command = commands[0];
                string item = commands[1];

                if (command == "Urgent")
                {
                    if (!items.Contains(item))
                    {
                        items.Insert(0, item);
                    }
                }
                else if (command == "Unnecessary")
                {
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }
                }
                else if (command == "Correct")
                {
                    string newItem = commands[2];
                    if (items.Contains(item))
                    {
                        items.Insert(items.IndexOf(item), newItem);
                        items.Remove(item);
                    }
                }
                else if (command == "Rearrange")
                {
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                        items.Add(item);
                    }
                }
            }
            Console.WriteLine(String.Join(", ", items));
        }
    }
}
