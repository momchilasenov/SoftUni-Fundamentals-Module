using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadAListOfInts();

            string input = string.Empty;
            bool isChanged = false;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "Remove")
                {
                    numbers.Remove(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    isChanged = true;
                }

                else if (command[0] == "Contains")
                {
                    Contains(numbers, int.Parse(command[1]));
                }
                else if (command[0] == "PrintEven")
                {
                    PrintEven(numbers);
                    Console.WriteLine();
                }
                else if (command[0] == "PrintOdd")
                {
                    PrintOdd(numbers);
                    Console.WriteLine();
                }
                else if (command[0] == "GetSum")
                {
                    GetSum(numbers);
                }
                else if (command[0] == "Filter")
                {
                    Filter(numbers, command[1], int.Parse(command[2]));
                }

            }
            if (isChanged)
            {
                Console.WriteLine(String.Join(' ', numbers));
            }
        }

        static List<int> ReadAListOfInts()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            return numbers;
        }

        static void Contains(List<int> numbers, int first)
        {
            if (numbers.Contains(first))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        static void PrintEven(List<int> numbers)
        {
            List<int> evenList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenList.Add(numbers[i]);
                }
            }
            Console.Write(String.Join(' ', evenList));
        }
        static void PrintOdd(List<int> numbers)
        {
            List<int> OddList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    OddList.Add(numbers[i]);
                }

            }
            Console.Write(String.Join(' ', OddList));
        }
        static void GetSum(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
        static void Filter(List<int> numbers, string condition, int number)
        {
            if (condition == "<")
            {
                List<int> newList = new List<int>();
                for (int i = 0; i < numbers.Count; i++) //2 13 43 876 342 23 543
                {
                    if (numbers[i] < number)
                    {
                        newList.Add(numbers[i]);
                    }
                }
                Console.Write(String.Join(' ', newList));
            }
            else if (condition == ">")
            {
                List<int> newList = new List<int>();
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > number)
                    {
                        newList.Add(numbers[i]);
                    }
                }
                Console.Write(String.Join(' ', newList));
            }
            else if (condition == "<=")
            {
                List<int> newList = new List<int>();
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= number)
                    {
                        newList.Add(numbers[i]);
                    }
                }
                Console.Write(String.Join(' ', newList));
            }
            else if (condition == ">=")
            {
                List<int> newList = new List<int>();
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] >= number)
                    {
                        newList.Add(numbers[i]);
                    }
                }
                Console.Write(String.Join(' ', newList));
            }
            Console.WriteLine();
        }
    }
}

