using System;
using System.Linq;
using System.Collections.Generic;


namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine(); 
            int movesCounter = 0;

            while (input != "end")
            {
                movesCounter++;
                string[] indexes = input.Split().ToArray();
                int firstIndex = int.Parse(indexes[0]);
                int secondIndex = int.Parse(indexes[1]);

                if (firstIndex >= 0
                    && firstIndex < elements.Count
                    && secondIndex >= 0
                    && secondIndex < elements.Count)
                {
                    if (elements[firstIndex] == elements[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");
                        elements.RemoveAt(Math.Max(firstIndex, secondIndex)); //ако махна първо по-големия индекс другият няма да се повлияе
                        elements.RemoveAt(Math.Min(firstIndex, secondIndex));
                    }
                    else if (elements[firstIndex] != elements[secondIndex])
                    {
                        Console.WriteLine("Try again!");
                        input = Console.ReadLine();
                        continue;
                    }

                    if (elements.Count == 0)
                    {
                        Console.WriteLine($"You have won in {movesCounter} turns!");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    elements.Insert(elements.Count / 2, $"-{movesCounter}a");
                    elements.Insert(elements.Count / 2, $"-{movesCounter}a");
                    
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

                input = Console.ReadLine();
            }
            if (elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(' ', elements));
            }
        }
    }
}
