using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split();

                if (commands[0] == "Delete")
                {
                    numbers = DeleteElement(numbers, int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    numbers = InsertElement(numbers, int.Parse(commands[1]), int.Parse(commands[2]));
                }
            }

            Console.WriteLine(String.Join(' ', numbers));

        }

        static List<int> DeleteElement(List<int> numbers, int element)
        {
            while (numbers.Remove(element)) { }
            return numbers;

            

        }

        static List<int> InsertElement(List<int> numbers, int element, int position)
        {
            numbers.Insert(position, element);
            return numbers;
        }
    }
}
