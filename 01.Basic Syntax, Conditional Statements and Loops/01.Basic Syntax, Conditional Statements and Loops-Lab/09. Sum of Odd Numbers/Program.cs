using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;

            //for (int i = 1; i <= n; i++)//2
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //        sum += i;
            //    }
            //    else
            //    {
            //        n += 1;
            //    }
            //}
            //Console.WriteLine($"Sum: {sum}");

            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;

            //for (int i = 1; i <= n; i++) 
            //{
            //    Console.WriteLine(2*i-1);
            //    sum += 2 * i - 1;
            //}
            //Console.WriteLine($"Sum: {sum}");

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int k = 1;

            for (int i = 1; i <= n; i++)
            {
                int number = 3 * i - k++;
                Console.WriteLine(number); 
                sum += number;
            }
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
