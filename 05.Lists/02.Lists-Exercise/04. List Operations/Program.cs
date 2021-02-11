using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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

            while ((input = Console.ReadLine()) != "End")
            {
                List<string> commands = input.Split().ToList();

                if (commands[0] == "Add")
                {
                    numbers = AddNumber(numbers, int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    if (int.Parse(commands[2]) < numbers.Count && int.Parse(commands[2]) >= 0)
                    {
                        numbers = InsertNumber(numbers, int.Parse(commands[1]), int.Parse(commands[2]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                }
                else if (commands[0] == "Remove")
                {
                    if (int.Parse(commands[1]) < numbers.Count && int.Parse(commands[1]) >= 0)
                    {
                        numbers = RemoveAtIndex(numbers, int.Parse(commands[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                }
                else if (commands[0] == "Shift" && commands[1] == "left")
                {
                    numbers = ShiftLeft(numbers, int.Parse(commands[2]));
                }
                else if (commands[0] == "Shift" && commands[1] == "right")
                {
                    numbers = ShiftRight(numbers, int.Parse(commands[2]));
                }
            }

            Console.WriteLine(String.Join(' ', numbers));
        }

        static List<int> AddNumber(List<int> numbers, int number)
        {
            numbers.Add(number);
            return numbers;
        }

        static List<int> InsertNumber(List<int> numbers, int number, int index)
        {
            numbers.Insert(index, number);
            return numbers;
        }

        static List<int> RemoveAtIndex(List<int> numbers, int index)
        {
            numbers.RemoveAt(index);
            return numbers;
        }

        static List<int> ShiftLeft(List<int> numbers, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                int lastIndex = numbers[0];

                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Add(lastIndex);
            }
            return numbers;


        }
        static List<int> ShiftRight(List<int> numbers, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                int firstIndex = numbers[numbers.Count - 1];

                for (int j = numbers.Count - 1; j >= 1; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = firstIndex;
            }
            return numbers;
        }

    }
}
