using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string first = strings[0];
            string second = strings[1];

            int result = 0;
            int extraSum = 0;
            int total = 0;

            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    result = first[i] * second[i];
                    total += result;
                }
            }
            if (first.Length != second.Length)
            {
                for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
                {
                    result = first[i] * second[i];
                    total += result;
                }

                if (first.Length > second.Length)
                {
                    for (int i = second.Length; i < first.Length; i++)
                    {
                        extraSum += (int)first[i];
                    }
                }
                else if (second.Length > first.Length)
                {
                    for (int i = first.Length; i < second.Length; i++)
                    {
                        extraSum += (int)second[i];
                    }
                }
            }
            Console.WriteLine(total + extraSum);
        }
    }
}
