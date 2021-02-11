using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
          

            List<string> numbers = Console.ReadLine()
                .Split('|')
                .ToList();

            numbers.Reverse();

            List<string> newList = new List<string>();

            foreach (string currentElement in numbers)
            {
                string[] elements = currentElement.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string element in elements)
                {
                    newList.Add(element);
                }
            }
            Console.WriteLine(String.Join(' ', newList));





        }
    }
}
