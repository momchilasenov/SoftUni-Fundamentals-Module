using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> Products = new List<string>();

            for (int i = 1; i <= number; i++)
            {
                Products.Add(Console.ReadLine());
            }

            Products.Sort();

            for (int i=1; i<=number; i++)
            {
                Console.WriteLine($"{i}.{Products[i-1]}");
            }
        }
    }
}
