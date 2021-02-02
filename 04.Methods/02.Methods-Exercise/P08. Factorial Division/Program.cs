using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            double result = FactorialOfNumbers(first, second);
            Console.WriteLine($"{result:f2}");
        }

        static double FactorialOfNumbers(int first, int second)
        {
            double firstSum = 1;
            for (int i = 1; i <= first; i++)
            {
                firstSum *= i;
            }
            double secondSum = 1;
            for (int i = 1; i <= second; i++)
            {
                secondSum *= i;
            }
            double result = firstSum / secondSum;
            return result;
        }
    }
}
