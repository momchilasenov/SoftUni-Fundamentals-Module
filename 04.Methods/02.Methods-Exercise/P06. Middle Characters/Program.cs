using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleChar(input);
        }

        static void PrintMiddleChar(string input)
        {
            int stringLength = input.Length;
            int middleChar = 0;

            if (stringLength % 2 != 0)
            {
                middleChar = (stringLength / 2);
                Console.WriteLine(input[middleChar]);

            }

            else if (stringLength % 2 == 0)
            {
                int firstMiddleChar = stringLength / 2 - 1;
                int secondMiddleChar = (stringLength / 2);
                Console.WriteLine($"{input[firstMiddleChar]}{input[secondMiddleChar]}");
            }

        }
    }
}
