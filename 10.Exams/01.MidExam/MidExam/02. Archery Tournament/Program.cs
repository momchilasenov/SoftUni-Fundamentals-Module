using System;
using System.Linq;

namespace _02._Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = string.Empty;
            int totalPoints = 0;
            int landIndex = 0;

            while ((input = Console.ReadLine()) != "Game over")
            {
                string[] commands = input
                    .Split(new char[] { ' ', '@' }, StringSplitOptions
                    .RemoveEmptyEntries);
                string command = commands[0];

                if (command == "Shoot")
                {
                    int startIndex = int.Parse(commands[2]);
                    int length = int.Parse(commands[3]);

                    if (startIndex < 0 || startIndex >= targets.Length) //DEBUG baby!
                    {
                        continue;
                    }

                    if (commands[1] == "Left") 
                                               
                    {
                        length = length % targets.Length; 
                        int offset = targets.Length - length; 

                        landIndex = (startIndex + offset) % targets.Length;

                    }
                    else if (commands[1] == "Right")
                    {
                        length = length % targets.Length;
                        
                        landIndex = (startIndex + length) % targets.Length;
                    }

                    if (targets[landIndex] >= 5)
                    {
                        targets[landIndex] -= 5;
                        totalPoints += 5;
                    }
                    else if (targets[landIndex] < 5)
                    {
                        totalPoints += targets[landIndex];
                        targets[landIndex] = 0;
                    }

                }
                else if (command == "Reverse")
                {
                        for (int i = 0; i < targets.Length / 2; i++)
                        {
                            int temp = targets[i];
                            targets[i] = targets[targets.Length - i - 1];
                            targets[targets.Length - i - 1] = temp;
                        }
                }

            }
            Console.WriteLine(String.Join(" - ", targets));
            Console.WriteLine($"Iskren finished the archery tournament with {totalPoints} points!");
        }
    }
}
