using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Orders_with_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            double totalPrice = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }

                string[] data = input.Split();
                string name = data[0];
                double price = double.Parse(data[1]);
                int quantity = int.Parse(data[2]);

                Product product = new Product(name, price, quantity);

                if (products.ContainsKey(name))
                {
                    products[name].Quantity += quantity;
                    if (price != products[name].Price)
                    {
                        products[name].Price = price;
                    }

                }
                else
                {
                    products.Add(name, product);
                }

            }
            foreach (var product in products)
            {
                totalPrice = product.Value.Price * product.Value.Quantity;
                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
