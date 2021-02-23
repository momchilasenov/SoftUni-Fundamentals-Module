using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double totalPrice = 0;

            Dictionary<string, List<double>> itemInfo = new Dictionary<string, List<double>>();

            while (true)
            {
                input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }

                string[] data = input.Split();
                string product = data[0];
                double price = double.Parse(data[1]);
                double quantity = double.Parse(data[2]);

                if (itemInfo.ContainsKey(product))
                {
                    itemInfo[product][1] += quantity;

                    if (price != itemInfo[product][0])
                    {
                        itemInfo[product][0] = price;
                    }
                }
                else
                {
                    itemInfo.Add(product, new List<double>());
                    itemInfo[product].Add(price);
                    itemInfo[product].Add(quantity);
                }
            }

            foreach(var item in itemInfo)
            {
                totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
