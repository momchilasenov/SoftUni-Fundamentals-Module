using System;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfAdventure = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDayPerPerson = double.Parse(Console.ReadLine());
            double foodPerDayPerPerson = double.Parse(Console.ReadLine());

            double totalWater = daysOfAdventure * players * waterPerDayPerPerson;
            double totalFood = daysOfAdventure * players * foodPerDayPerPerson;
            bool failedQuest = false;

            for (int i = 1; i <= daysOfAdventure; i++)
            {
                double energyLost = double.Parse(Console.ReadLine());
                if (energyLost >= groupEnergy)
                {
                    failedQuest = true;
                    break;
                }
                groupEnergy -= energyLost;
                if (i % 2 == 0)
                {
                    groupEnergy += groupEnergy * 0.05;
                    totalWater -= totalWater * 0.3;
                }
                if (i % 3 == 0)
                {
                    totalFood -= totalFood/players;
                    groupEnergy += groupEnergy * 0.1;
                }
            }
            if (failedQuest)
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }

            else
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }

        }
    }
}
