using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine())!= "end")
            {
                string[] commands = input.Split().ToArray();
                string command = commands[0];

                if (command == "swap")
                {
                    int firstIndex = int.Parse(commands[1]);
                    int secondIndex = int.Parse(commands[2]);

                    int temp = numbers[firstIndex];
                    numbers[firstIndex] = numbers[secondIndex];
                    numbers[secondIndex] = temp;
                }
                else if (command == "multiply")
                {
                    int firstIndex = int.Parse(commands[1]);
                    int secondIndex = int.Parse(commands[2]);

                    numbers[firstIndex] = numbers[firstIndex] * numbers[secondIndex];
                }
                else if (command == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
            }
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
