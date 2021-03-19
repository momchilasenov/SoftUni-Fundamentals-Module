using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] commands = input
                    .Split(new char[] { ' ', '-',':' }, StringSplitOptions
                    .RemoveEmptyEntries);

                string command = commands[0];

                if (command == "Collect")
                {
                    string item = commands[1];
                    if (!items.Contains(item))
                    {
                        items.Add(item);
                    }
                }
                else if (command == "Drop")
                {
                    string item = commands[1];
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }
                }
                else if (command == "Combine")
                {
                    string oldItem = commands[2];
                    string newItem = commands[3];

                    if (items.Contains(oldItem))
                    {
                        items.Insert(items.IndexOf(oldItem)+1, newItem);
                    }
                }
                else if (command == "Renew")
                {
                    string item = commands[1];
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
