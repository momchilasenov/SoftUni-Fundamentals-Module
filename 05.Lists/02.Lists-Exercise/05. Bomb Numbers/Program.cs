using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCards = int.MinValue;
            if (firstPlayer.Count > maxCards)
            {
                maxCards = firstPlayer.Count;
            }

            for (int i = 0; i < maxCards; i++)
            {
                if (firstPlayer.Count > maxCards)
                {
                    maxCards = firstPlayer.Count;
                }
                else if (secondPlayer.Count > maxCards)
                {
                    maxCards = secondPlayer.Count;
                }

                if (firstPlayer.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
                    break;
                }
                else if (secondPlayer.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
                    break;
                }

                if (firstPlayer[i] > secondPlayer[i])
                {
                    firstPlayer.Add(firstPlayer[i]);
                    firstPlayer.Add(secondPlayer[i]);
                    secondPlayer.RemoveAt(i);
                    firstPlayer.RemoveAt(i);
                    i = -1;
                }
                else if (secondPlayer[i] > firstPlayer[i])
                {
                    secondPlayer.Add(secondPlayer[i]);
                    secondPlayer.Add(firstPlayer[i]);
                    firstPlayer.RemoveAt(i);
                    secondPlayer.RemoveAt(i);
                    i = -1;
                }
                else if (firstPlayer[i] == secondPlayer[i])
                {
                    firstPlayer.RemoveAt(i);
                    secondPlayer.RemoveAt(i);
                    i = -1;
                }
            }
        }


    }
}
