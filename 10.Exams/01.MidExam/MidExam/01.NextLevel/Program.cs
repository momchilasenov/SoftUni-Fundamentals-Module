using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExperience = double.Parse(Console.ReadLine());
            int expectedBattles = int.Parse(Console.ReadLine());

            double totalExperience = 0;
            int battlesCount = 0;

            for (int i = 1; i <= expectedBattles; i++)
            {
                battlesCount++;
                double currentExperienceEarned = double.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    currentExperienceEarned += currentExperienceEarned * 0.15;
                }
                if (i % 5 == 0)
                {
                    currentExperienceEarned -= currentExperienceEarned * 0.10;
                }
                if (i % 15 == 0)
                {
                    currentExperienceEarned += currentExperienceEarned * 0.05;
                }

                totalExperience += currentExperienceEarned;
                
                if (totalExperience >= neededExperience)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {battlesCount} battles.");
                    break;
                }

            }

            if (neededExperience > totalExperience)
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperience - totalExperience:f2} more needed.");
            }
        }
    }
}
