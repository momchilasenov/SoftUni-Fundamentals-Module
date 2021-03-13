using System;
using System.Linq;
using System.Text;

namespace _08._Letters_Change_Numbers_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            // A12b s17G
            char firstLetter;
            char secondLetter;

            double totalResult = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currentWord = input[i];
                double currentResult = 0;

                firstLetter = currentWord[0];
                int firstPosition = (int)firstLetter % 32;

                secondLetter = currentWord[currentWord.Length - 1];
                int secondPosition = (int)secondLetter % 32;

                double number = double.Parse(currentWord.Substring(1, currentWord.Length - 2));

                //firstLetter logic
                if (char.IsUpper(firstLetter))
                {
                    currentResult = number * 1.0 / firstPosition;
                }
                else if (char.IsLower(firstLetter))
                {
                    currentResult = number * firstPosition;
                }

                //secondLetter logic
                if (char.IsUpper(secondLetter))
                {
                    currentResult -= secondPosition;
                }
                else if (char.IsLower(secondLetter))
                {
                    currentResult += secondPosition;
                }

                totalResult += currentResult;

            }
            Console.WriteLine($"{totalResult:f2}");


        }
    }
}
