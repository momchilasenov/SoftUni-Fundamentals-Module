using System;
using System.Linq;
using System.Collections.Generic;

namespace More_Exercises_01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split()
                .ToList();

            string message = Console.ReadLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = int.Parse(numbers[i]);
                int currentSum = CalculateSum(currentNumber);

                //int theIndexToSelect = currentSum % numbers.Count; //NB - maybe -1

                char currentChar = GetCharFromText(currentSum, message);

                Console.Write(currentChar);

                int indexToRemove = CalculateIndex(currentSum, message);
                string newMessage = message.Remove(indexToRemove, 1);
                message = newMessage;

            }
        }

        static int CalculateSum(int currentNumber)
        {
            int currentSum = 0;
            while (currentNumber > 0)
            {
                int digit = currentNumber % 10; //take the last digit
                currentSum += digit; //add it to the current sum
                currentNumber /= 10; //remove the last digit
            }
            return currentSum;
        }

        static int CalculateIndex(int currentSum, string message)
        {
            int indexCounter = 0;

            for (int i = 0; i < currentSum; i++)
            {
                indexCounter++;
                if (indexCounter == message.Length)
                {
                    indexCounter = 0;
                }
            }
            return indexCounter;
        }

        static char GetCharFromText(int currentSum, string message)
        {
            int indexCounter = 0;

            for (int i = 0; i < currentSum; i++)
            {
                indexCounter++;
                if (indexCounter == message.Length)
                {
                    indexCounter = 0;
                }
            }

            char currentChar = message[indexCounter];
            return currentChar;

        }
    }
}
