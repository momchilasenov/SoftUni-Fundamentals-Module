using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            double averageValue = numbers.Sum() / numbers.Count;
            List<double> maxNumbers = new List<double>();
            double smallestNumber = double.MaxValue;

            foreach (int number in numbers.Where(x => x > averageValue))
            { //we build the list with max elements
                maxNumbers.Add(number);
            }

            if (maxNumbers.Count > 5)
            {
                while (maxNumbers.Count > 5)
                {
                    for (int i = 0; i < maxNumbers.Count; i++) 
                    {
                        if (maxNumbers[i] < smallestNumber)
                        {
                            smallestNumber = maxNumbers[i];
                        }
                    }
                    maxNumbers.Remove(smallestNumber);
                    smallestNumber = double.MaxValue;
                }
            }

            if (maxNumbers.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }
            maxNumbers = maxNumbers.OrderByDescending(x => x).ToList();
            Console.WriteLine(string.Join(' ', maxNumbers));
        }
    }
}
