using System;

namespace More_Exercises_02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] rowsOfNumbers = new int[n];
            int[] oldNumbers = new int[] { 1 };

            for (int i = 0; i < n; i++) 
            {
                int[] numbers = new int[i + 1]; 

                for (int j = 0; j < numbers.Length; j++) 
                {
                    if (j == 0 || j == numbers.Length - 1)
                   
                    {
                        numbers[j] = 1;
                    }
                    else if (j > 0 && j < numbers.Length)
                    {
                        numbers[j] = oldNumbers[j - 1] + oldNumbers[j];
                    }
                }
                Console.WriteLine(String.Join(' ', numbers));
                oldNumbers = numbers; 
            }
        }
    }
}
