using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double coin = 0;
            double sumOfCoins = 0;

            while (input != "Start")
            {
                coin = double.Parse(input);
                bool coinOrNot = (coin == 0.1) || (coin == 0.2) || (coin == 0.5) || (coin == 1.0) || (coin == 2.0);
                if (coinOrNot)
                {
                    sumOfCoins += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                input = Console.ReadLine();
            }

            string order = Console.ReadLine();
            double price = 0;

            while (order != "End")
            {
                if (order == "Nuts")
                {
                    price = 2.0;
                }
                else if (order == "Water")
                {
                    price = 0.7;
                }
                else if (order == "Crisps")
                {
                    price = 1.5;
                }
                else if (order == "Soda")
                {
                    price = 0.8;
                }
                else if (order == "Coke")
                {
                    price = 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    order = Console.ReadLine();
                    continue;
                }

                if (sumOfCoins >= price)
                {
                    sumOfCoins -= price;
                    Console.WriteLine($"Purchased {order.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money"); 
                }
                order = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sumOfCoins:f2}");


        }
    }
}
