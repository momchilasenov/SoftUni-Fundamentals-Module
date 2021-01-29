using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculator(first, sign, second));
        }

        static double Calculator (int first, char sign, int second)
        {
            double result = 0;

            if (sign == '*')
            {
                result = first * second;
            }
            else if (sign == '/')
            {
                result = first / second;
            }
            else if (sign == '+')
            {
                result = first + second;
            }
            else if (sign == '-')
            {
                result = first - second;
            }

            return result;
        }
    }
}
