using System;

namespace More_Exercises_03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            //1, 1, 2, 3, 5, 8, 13, 21, 34
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                {
                    numbers[i] = 1;
                }
                else
                {
                    numbers[i] = numbers[i - 1] + numbers[i - 2];
                }

            }
            Console.WriteLine(numbers[n-1]);

            //with recurtion 

            int n = int.Parse(Console.ReadLine());

            
        }

        static int GetFibonacci(int n)
        {
            int[] numbers = new int[n];
                
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == 1)
                {
                    numbers[i] = 1;
                }
                else
                {
                    numbers[i] = numbers[i - 1] + numbers[i - 2];
                }

            }
            GetFibonacci(n) = GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }
}
