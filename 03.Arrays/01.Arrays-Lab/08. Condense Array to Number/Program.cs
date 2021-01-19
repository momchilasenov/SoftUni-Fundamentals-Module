using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //For loop solution

            int[] numbers = Console.ReadLine() 
                .Split()
                .Select(int.Parse)
                .ToArray();

            
            int iterations = numbers.Length-1;

            for (int j = 0; j < iterations; j++)
            {
                int[] newArr = new int[numbers.Length - 1]; 
                
                for (int i = 0; i<newArr.Length; i++) //4 3 2
                {
                    newArr[i] = numbers[i] + numbers[i + 1];
                }
                numbers = newArr;
            }
            Console.WriteLine(string.Join(" ", numbers));

            //While loop solution

            //int[] numbers = Console.ReadLine() // 3 5 7 9
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            //while (numbers.Length != 1)
            //{
            //    int[] newArr = new int[numbers.Length - 1];

            //    for (int i = 0; i < newArr.Length; i++) 
            //    {

            //        newArr[i] = numbers[i] + numbers[i + 1];

            //    }
            //    numbers = newArr; 
            //    Console.WriteLine(String.Join(" ", numbers));
            //}
            //Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
