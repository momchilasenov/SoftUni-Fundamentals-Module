using System;
using System.Collections.Generic;

namespace More_Exercises_04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            TribonacciSequence(num);


        }

        static void TribonacciSequence(int num)
        {
            List<int> numbers = new List<int>(); 

            int first = 1;
            int second = 1;
            int third = 2;
            numbers.Add(first);
            numbers.Add(second);
            numbers.Add(third);

            for (int i = 0; i < num; i++)
            {
                int nextNumber = numbers[i] + numbers[i + 1] + numbers[i + 2];
                numbers.Add(nextNumber);
                Console.Write(numbers[i]+" ");
            }

            

        }
    }
}
