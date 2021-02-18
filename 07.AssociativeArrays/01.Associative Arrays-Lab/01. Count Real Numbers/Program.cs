using System;
using System.Collections.Generic;
using System.Linq;


namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8 2,5 2,5 8 2,5

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int counter = 1;

            //8 2 8 2 8

            SortedDictionary<int, int> sortedNums = new SortedDictionary<int, int>();

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (!sortedNums.ContainsKey(numbers[i]))
            //    {
            //        sortedNums.Add(numbers[i], counter);
            //    }
            //    else
            //    {
            //        sortedNums[numbers[i]] += counter;
            //    }
            //}

            foreach (int number in numbers)
            {
                if (sortedNums.ContainsKey(number))
                {
                    sortedNums[number]++; //увеличаваме стойността с 1
                }
                else
                {
                    sortedNums.Add(number, 1);
                }
            }

            foreach (var num in sortedNums)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }

        }
    }
}
