using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine() // 1 2 3 4 
                .Split()
                .Select(int.Parse)
                .ToArray();

            int counter = 2;
            int givenNumber = int.Parse(Console.ReadLine()); //5

            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == givenNumber)
                    {
                        int[] newArr = new int[counter];
                        newArr[0] = numbers[i];
                        newArr[1] = numbers[j];
                        Console.WriteLine(String.Join(" ", newArr));
                    }
                }
                
            }


        }
    }
}
