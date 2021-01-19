using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();

            //string[] splitted = input.Split();
            //double[] numbers = new double[splitted.Length];

            //for (int i = 0; i < splitted.Length; i++)
            //{
            //    numbers[i] = double.Parse(splitted[i]); 
            //    int number = (int)Math.Round(numbers[i],MidpointRounding.AwayFromZero);
            //    if (numbers[i] == 0)
            //    {
            //        numbers[i] = 0;
            //    }
            //    Console.WriteLine($"{numbers[i]} => {number}");
            //}

            //Another solution 

            //double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            //for (int i=0; i < nums.Length; i++)
            //{
            //    if (nums[i] == 0)
            //    {
            //        nums[i] = 0;
            //    }
            //    Console.WriteLine($"{nums[i]} => {(int)Math.Round(nums[i],MidpointRounding.AwayFromZero)}");
            //}

            //Another solution

            double[] numbers = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i=0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} -> {Math.Round(numbers[i],MidpointRounding.AwayFromZero)}");
            }
            
        }
    }
}
