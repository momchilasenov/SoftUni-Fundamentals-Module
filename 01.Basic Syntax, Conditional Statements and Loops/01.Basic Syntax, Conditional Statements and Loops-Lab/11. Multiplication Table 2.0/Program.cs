using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            //int multiplier = int.Parse(Console.ReadLine());

            //for (int i=multiplier; i<=10; i++)
            //{
            //    int result = number * i;
            //    Console.WriteLine($"{number} X {i} = {result}");
            //}
            //if (multiplier > 10)
            //{
            //    Console.WriteLine($"{number} X {multiplier} = {number*multiplier}");
            //}

            //Решение с While цикъл
            //int number = int.Parse(Console.ReadLine());
            //int multiplier = int.Parse(Console.ReadLine());

            //if (multiplier > 10)
            //{
            //    Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
            //    return;
            //}

            //while (multiplier <= 10)
            //{
            //    int result = number * multiplier;
            //    Console.WriteLine($"{number} X {multiplier} = {result}");
            //    multiplier++;
            //}

            //Решение с DO...While цикъл
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            do
            {
                int result = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {result}");
                multiplier++;
            } while (multiplier <= 10);


        }
    }
}
