using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ReadListOfInts(); 
            Console.WriteLine(String.Join(' ', SumPairs(list)));
        }

        static List<int> SumPairs(List<int> list)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < list.Count / 2; i++) //1 2 3 4 5 //1 2 3 4 
            {
                result.Add(list[i] + list[list.Count - i - 1]);
            }
            if (list.Count % 2 != 0)
            {
                result.Add(list[list.Count / 2]);
            }
            return result;
        }


        static List<int> ReadListOfInts()
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            return list;
        }
    }
}
