using System;
using System.Linq;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //for (int j = n - 1; j >= 0; j--) //3
            //{
            //    Console.Write(numbers[j] + " ");
            //}

            //ИЛИ
            for (int j = 0; j < n; j++) 
            {
                Console.Write(numbers[numbers.Length - j - 1] + " "); //3-0-1 = 2 element
            }

            //ИЛИ
            Console.WriteLine(string.Join(' ', numbers.Reverse()));

            //ИЛИ
            int[] numbers = numbers.Reverse().ToArray(); 

        }
    }
}
