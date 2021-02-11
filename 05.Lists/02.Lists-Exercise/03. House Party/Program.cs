using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> people = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string input = Console.ReadLine();
                string[] inputs = input.Split();

                if (inputs[2] == "going!")
                {
                    if (!people.Contains(inputs[0]))
                    {
                        people.Add(inputs[0]);
                    }
                    else if (people.Contains(inputs[0]))
                    {
                        Console.WriteLine($"{inputs[0]} is already in the list!");
                        continue;
                    }
                }
                else if (inputs[2] == "not")
                {
                    if (people.Contains(inputs[0]))
                    {
                        people.Remove(inputs[0]);
                    }
                    else if (!people.Contains(inputs[0]))
                    {
                        Console.WriteLine($"{inputs[0]} is not in the list!");
                        continue;
                    }
                }
            }
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i]);
            }
        }
    }
}
