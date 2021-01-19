using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numbersArr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool areEqual = false;
            int sum = 0;

            for (int i = 0; i < numbersArr1.Length; i++)
            {
                if (numbersArr1[i] == numbersArr2[i])
                {
                    sum += numbersArr1[i];
                    areEqual = true;
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }

            if (areEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            
        }
    }
}
