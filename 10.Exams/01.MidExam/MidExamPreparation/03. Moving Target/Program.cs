using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputs = input.Split().ToArray();
                string command = inputs[0];
                int index = int.Parse(inputs[1]);

                if (command == "Shoot")
                {
                    int power = int.Parse(inputs[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (command == "Add")
                {
                    int value = int.Parse(inputs[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid placement!");
                    }
                }
                else if (command == "Strike")
                {
                    int radius = int.Parse(inputs[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        if (index-radius >= 0 && index+radius < targets.Count) //52 23 44 96 100 65 69
                        {
                            //1st solution
                            //targets.RemoveRange(index - radius, radius+radius+1);

                            //2nd solution
                            for (int i= index-radius; i<=index+radius; i++)
                            {
                                targets.RemoveAt(index - radius); //винаги премахваме първия индекс защото след премахването те се изместват наляво
                            }
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }

                    }

                }
            }
            Console.WriteLine(String.Join('|', targets));
        }
    }
}
