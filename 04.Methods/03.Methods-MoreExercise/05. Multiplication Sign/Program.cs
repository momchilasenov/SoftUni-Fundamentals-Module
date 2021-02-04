using System;
using System.Collections.Generic;
using System.Linq;

namespace More_Exercises_05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            if (numbers.Contains(0))
            {
                Console.WriteLine("zero");
                return;
            }

            int negativeCount = 0;

            foreach (int number in numbers.Where(x => x < 0))
            {
                negativeCount++;
            }

            if (negativeCount % 2 != 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}
