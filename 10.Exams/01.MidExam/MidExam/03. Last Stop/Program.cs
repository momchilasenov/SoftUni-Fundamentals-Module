using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> paintings = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] commands = input.Split().ToArray();

                string command = commands[0];

                if (command == "Change")
                {
                    int numberOfPainting = int.Parse(commands[1]);
                    int changeNumber = int.Parse(commands[2]);

                    if (paintings.Contains(numberOfPainting))
                    {
                        paintings[paintings.IndexOf(numberOfPainting)] = changeNumber;
                    }

                }
                else if (command == "Hide")
                {
                    int numberOfPainting = int.Parse(commands[1]);

                    if (paintings.Contains(numberOfPainting))
                    {
                        paintings.Remove(numberOfPainting);
                    }
                }
                else if (command == "Switch")
                {
                    int firstPainting = int.Parse(commands[1]);
                    int secondPainting = int.Parse(commands[2]);

                    if (paintings.Contains(firstPainting) && paintings.Contains(secondPainting))
                    {
                        int firstIndex = paintings.IndexOf(firstPainting);
                        int secondIndex = paintings.IndexOf(secondPainting);
                        int temp = firstPainting;
                        paintings[firstIndex] = secondPainting;
                        paintings[secondIndex] = temp;
                    }
                }
                else if (command == "Insert")
                {
                    int place = int.Parse(commands[1]);
                    int numberOfPainting = int.Parse(commands[2]);
                    if (place + 1 >= 0 && place + 1 < paintings.Count)
                    {
                        paintings.Insert(place + 1, numberOfPainting);
                    }
                }

                else if (command == "Reverse")
                {
                    paintings.Reverse();
                }

            }
            Console.WriteLine(String.Join(' ', paintings));
        }
    }
}
