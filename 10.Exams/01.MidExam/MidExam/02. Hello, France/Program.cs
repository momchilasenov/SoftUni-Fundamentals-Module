using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _02._Hello__France
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            double budget = double.Parse(Console.ReadLine());
            double tradeAllowance = 0.4;
            double newItemPrice = 0;
            List<double> itemsToSell = new List<double>();
            double profit = 0;

            for (int i = 0; i < items.Length; i++)
            {
                string[] item = items[i].Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = item[0];
                double price = double.Parse(item[1]);

                if (type == "Clothes" && price > 50)
                {
                    continue;
                }
                else if (type == "Shoes" && price > 35)
                {
                    continue;
                }
                else if (type == "Accessories" && price >20.5)
                {
                    continue;
                }

                if (budget < price)
                {
                    continue;
                }

                budget -= price;
                newItemPrice = price + (price * tradeAllowance);
                profit += newItemPrice - price;
                itemsToSell.Add(newItemPrice);

            }

            double totalMoney = itemsToSell.Sum() + budget;
            double moneyNeeded = 150;
            foreach(double item in itemsToSell)
            {
                Console.Write($"{item:f2} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Profit: {profit:f2}");

            if (totalMoney >= moneyNeeded)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
