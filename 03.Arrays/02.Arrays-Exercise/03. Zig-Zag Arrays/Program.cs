using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            int indexZero = 0;
            int indexOne = 1;

            for (int i = 0; i < n; i++) 
            {
                string numbers = Console.ReadLine();

                int[] numberArr = numbers.Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0) 
                {
                    firstArr[i] = numberArr[indexZero]; 
                    secondArr[i] = numberArr[indexOne];
                }
                else
                {
                    firstArr[i] = numberArr[indexOne]; 
                    secondArr[i] = numberArr[indexZero];
                }
            }

            for (int i=0; i<n; i++)
            {
                Console.Write($"{firstArr[i]} ");
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{secondArr[i]} ");
            }
        }
    }
}
