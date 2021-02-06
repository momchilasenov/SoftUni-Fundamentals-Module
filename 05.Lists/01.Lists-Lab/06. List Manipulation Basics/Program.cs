using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadAListOfInts();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if(command[0] == "Remove")
                {
                    numbers.Remove(int.Parse(command[1]));
                }
                else if(command[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1])); //insert 8 3
                    
                }
            }
            Console.WriteLine(String.Join(' ', numbers));
        }

        static List<int> ReadAListOfInts()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            return numbers;
        }
    }
}
