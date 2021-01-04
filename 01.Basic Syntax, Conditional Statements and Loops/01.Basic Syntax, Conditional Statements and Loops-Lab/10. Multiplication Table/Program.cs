using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //Решение с FOR цикъл
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    int result = number * i;
            //    Console.WriteLine($"{number} X {i} = {result}");
            //}

            //Решение с While цикъл
            int number = int.Parse(Console.ReadLine());
            int multiplier = 1;

            while (multiplier <= 10)
            {
                int result = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {result}");
                multiplier++;
            }

        }
    }
}
