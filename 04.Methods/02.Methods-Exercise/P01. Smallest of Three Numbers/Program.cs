using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestOfThreeNumbers(first, second, third));
        }

        static int SmallestOfThreeNumbers(int first, int second, int third)
        {
            int smallestNumber = Math.Min(third, (Math.Min(first, second)));
            return smallestNumber;
        }
    }
}
