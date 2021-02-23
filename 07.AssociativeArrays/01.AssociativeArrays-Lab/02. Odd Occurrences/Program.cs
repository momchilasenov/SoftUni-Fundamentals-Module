using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split()
                .Select(x => x.ToLower())
                .ToList();

            Dictionary<string, int> elements = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (elements.ContainsKey(word))
                {
                    elements[word]++;
                }
                else
                {
                    elements.Add(word, 1);
                }
            }
            
            //foreach (var element in elements)
            //{
            //    if (element.Value % 2 != 0)
            //    {
            //        Console.Write(element.Key + " ");
            //    }
            //}

            foreach(var element in elements.Where(element => element.Value % 2 != 0))
            {
                Console.Write(element.Key + " ");
            }

        }
    }
}
