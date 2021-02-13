using System;
using System.Linq;
using System.Collections.Generic;

namespace More_Exercise_02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> times = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double leftRacerTime = 0;
            double rightRacerTime = 0;

            for (int i = 0; i < times.Count / 2; i++)
            {
                leftRacerTime += times[i];
                if (times[i] == 0)
                {
                    leftRacerTime -= leftRacerTime * 0.2;
                }
            }

            for (int i = times.Count - 1; i > times.Count / 2; i--)
            {
                rightRacerTime += times[i];
                if (times[i] == 0)
                {
                    rightRacerTime -= rightRacerTime * 0.2;
                }
            }
            string result = leftRacerTime > rightRacerTime 
                ? $"The winner is right with total time: {rightRacerTime}"
                : $"The winner is left with total time: {leftRacerTime}";

            Console.WriteLine(result);
        }

   }
}
