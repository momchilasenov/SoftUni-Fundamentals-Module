using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();

            
            //hardcore index = 2
            bool isEqual = false;

            for (int index = 0; index<numbers.Length; index++)
            {
                int rightSum = 0;
                int leftSum = 0;

                for (int i = index + 1; i < numbers.Length; i++)
                {
                    rightSum += numbers[i];
                }

                for (int i = index - 1; i >= 0; i--)
                {
                    leftSum += numbers[i];
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(index);
                    isEqual = true;
                }
            }
            if (!isEqual)
            {
                Console.WriteLine("no");
            }          

        }
    }
}
