using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int lastElement = numbers[0];

                int[] newArr = new int[numbers.Length];

                for (int j = 0; j < newArr.Length-1; j++) 
                {
                    newArr[j] = numbers[j+1];
                }
                newArr[newArr.Length - 1] = lastElement; 
                numbers = newArr;
            }

            Console.WriteLine(String.Join(' ', numbers));

        }
    }
}

