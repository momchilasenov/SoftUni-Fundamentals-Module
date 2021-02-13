using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            List<int> drumset = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> initialValues = new List<int>();
            initialValues.AddRange(drumset);

            string input = Console.ReadLine();
            int drumPrice = 0;

            while (input != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i < drumset.Count; i++) //27 2 4 7
                {
                    drumset[i] -= hitPower;

                    if (drumset[i] <= 0)
                    {
                        drumPrice = initialValues[i] * 3;
                        if (budget >= drumPrice)
                        {
                            drumset[i] = initialValues[i];
                            budget -= drumPrice;
                        }
                        else if (drumPrice > budget)
                        {
                            drumset.RemoveAt(i);
                            initialValues.RemoveAt(i);
                            --i;
                        }

                    }

                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', drumset));
            Console.WriteLine($"Gabsy has {budget:f2}lv.");

        }
    }
}
