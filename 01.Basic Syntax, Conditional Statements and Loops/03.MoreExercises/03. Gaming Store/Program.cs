using System;

namespace More_Exercises___03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            double totalSpent = 0;
            double price = 0;

            while (command != "Game Time")
            {
                if (command == "OutFall 4")
                {
                    price = 39.99;
                    currentBalance -= price;
                }
                else if (command == "CS: OG")
                {
                    price = 15.99;
                    currentBalance -= price;
                }
                else if (command == "Zplinter Zell")
                {
                    price = 19.99;
                    currentBalance -= price;
                }
                else if (command == "Honored 2")
                {
                    price = 59.99;
                    currentBalance -= price;
                }
                else if (command == "RoverWatch")
                {
                    price = 29.99;
                    currentBalance -= price;
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                    currentBalance -= price;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    command = Console.ReadLine();
                    continue;
                }

                if (currentBalance < 0)
                {
                    Console.WriteLine("Too Expensive");
                    currentBalance += price;
                }
                else if (currentBalance == 0)
                {
                    Console.WriteLine($"Bought {command}");
                    Console.WriteLine("Out of money!");
                    return;
                }
                else if (currentBalance > 0)
                {
                    Console.WriteLine($"Bought {command}");
                    totalSpent += price;
                }

                command = Console.ReadLine();
            }
            if (currentBalance > 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. " +
                                  $"Remaining: ${currentBalance:f2}");
            }
            
        }
    }
}
