using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fires = Console.ReadLine()
                .Split('#', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int water = int.Parse(Console.ReadLine());
            double effort = 0;
            double maximumEffort = 0;
            double totalFire = 0;
            List<int> cellsPutOut = new List<int>();

            for (int i = 0; i < fires.Length; i++)
            {
                string[] fireInput = fires[i]
                    .Split(new char[] { ' ', '=' }
                    , StringSplitOptions.RemoveEmptyEntries);
                string typeOfFire = fireInput[0];
                int fireStrength = int.Parse(fireInput[1]);

                if (typeOfFire == "High")
                {
                    if (fireStrength < 81 || fireStrength > 125)
                    {
                        continue;
                    }
                }
                else if (typeOfFire == "Medium")
                {
                    if (fireStrength < 51 || fireStrength > 80)
                    {
                        continue;
                    }
                }
                else if (typeOfFire == "Low")
                {
                    if (fireStrength < 1 || fireStrength > 50)
                    {
                        continue;
                    }
                }

                if (water >= fireStrength)
                {
                    water -= fireStrength;
                    totalFire += fireStrength;
                    cellsPutOut.Add(fireStrength);
                    effort = fireStrength * 0.25;
                    maximumEffort += effort;
                }
                else if (water < fireStrength)
                {
                    continue;
                }
            }
            Console.WriteLine("Cells:");
            foreach(int cell in cellsPutOut)
            {
                Console.WriteLine($" - {cell}");
            }
            Console.WriteLine($"Effort: {maximumEffort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");


        }
    }
}
