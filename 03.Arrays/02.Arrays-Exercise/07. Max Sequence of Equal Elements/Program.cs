using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bestLength = int.MinValue;
            int bestIndex = 0;

            for (int i = 0; i < numbers.Length; i++) 
            {
                int currentElement = numbers[i]; 
                int length = 1; 

                for (int currI = i + 1; currI < numbers.Length; currI++) 
                {
                    if (currentElement == numbers[currI]) 
                    {
                        length++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestIndex = i;
                }

            }

            for (int i = 0; i < bestLength; i++) 
            {
                Console.Write(numbers[bestIndex] + " ");
            }

        }
    }
}
