using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < numbersArr.Length; i++)
            {
                if (numbersArr[i] % 2 == 0)
                {
                    evenSum += numbersArr[i];
                }
                else
                {
                    oddSum += numbersArr[i];
                }
            }
            Console.WriteLine(evenSum-oddSum);
        }
    }
}
