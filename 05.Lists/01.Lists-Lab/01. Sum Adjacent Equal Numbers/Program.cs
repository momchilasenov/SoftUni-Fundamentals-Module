using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = ReadAListOfNumbers();

            for (int i = 0; i < list.Count-1; i++) //8 2 2 4 8 16
            {
                if (list[i] == list[i + 1])
                {
                    list[i] += list[i + 1];
                    list.Remove(list[i + 1]);
                    i = -1;
                }
            }
            Console.WriteLine(String.Join(' ', list));
        }

        static List<double> ReadAListOfNumbers()
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            return numbers;
        }
    }
}
