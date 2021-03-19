using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                .Split('@', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            int currentPosition = 0;
            int cupidsLocation = 0;
            int failedHouses = 0;

            while (input != "Love!")
            {
                string[] inputs = input
                    .Split(' ', StringSplitOptions
                    .RemoveEmptyEntries);

                int length = int.Parse(inputs[1]); //2

                cupidsLocation += length;

                if (cupidsLocation >= houses.Count)
                {
                    cupidsLocation = 0;
                }

                if (houses[cupidsLocation] == 0)
                {
                    Console.WriteLine($"Place {cupidsLocation} already had Valentine's day.");
                    input = Console.ReadLine();
                    continue;
                }

                houses[cupidsLocation] -= 2;

                if (houses[cupidsLocation] <= 0)
                {
                    Console.WriteLine($"Place {cupidsLocation} has Valentine's day.");
                }
                                
                input = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {cupidsLocation}.");

            if (houses.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                foreach(int house in houses.FindAll(x => x != 0))
                {
                    failedHouses++;
                }
                Console.WriteLine($"Cupid has failed {failedHouses} places."); 
            }
        }
    }
}
