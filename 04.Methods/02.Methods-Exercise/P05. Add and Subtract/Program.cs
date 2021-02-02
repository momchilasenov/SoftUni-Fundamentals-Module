using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int result = SubtractTwoDigits(first, second, third);
            Console.WriteLine(result);
        }

        static int SumTwoDigits(int first, int second)
        {
            return first + second;
        }

        static int SubtractTwoDigits(int first, int second, int third) //5
        {
            int sum = SumTwoDigits(first, second);
            return sum - third;
        }
    }
}
