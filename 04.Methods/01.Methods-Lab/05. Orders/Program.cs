using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int productQuantity = int.Parse(Console.ReadLine());
            TotalPriceOfOrder(order, productQuantity);
        }

        static void TotalPriceOfOrder(string order, int productQuantity)
        {
            if (order == "coffee")
            {
                Console.WriteLine($"{productQuantity * 1.50:f2}");
            }
            else if (order == "coke")
            {
                Console.WriteLine($"{productQuantity * 1.40:f2}");
            }
            else if (order == "water")
            {
                Console.WriteLine($"{productQuantity * 1.00:f2}"); 
            }
            else if (order == "snacks")
            {
                Console.WriteLine($"{productQuantity * 2.00:f2}");
            }

        }
    }
}
