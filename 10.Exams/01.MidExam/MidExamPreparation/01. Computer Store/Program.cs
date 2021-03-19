using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            double totalPrice = 0;
            double taxedTotalPrice = 0;
            double totalTaxes = 0;

            while (command != "special" && command != "regular")
            {
                double price = double.Parse(command);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }

                totalPrice += price;
                totalTaxes += price * 0.2;
                price += price * 0.2;
                taxedTotalPrice += price;

                command = Console.ReadLine();
            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            if (command == "special")
            {
                taxedTotalPrice -= taxedTotalPrice * 0.1;
            }
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
            Console.WriteLine($"Taxes: {totalTaxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {taxedTotalPrice:f2}$");
        }
    }
}
