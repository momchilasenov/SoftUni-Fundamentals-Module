using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] peopleArr = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                peopleArr[i] = int.Parse(Console.ReadLine());
                sum += peopleArr[i];

            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{peopleArr[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);


        }
    }
}
