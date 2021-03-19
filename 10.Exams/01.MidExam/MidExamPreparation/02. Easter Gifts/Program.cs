using System;
using System.Linq;

namespace _02._Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gifts = Console.ReadLine()
                .Split()
                .ToArray();

            string input = Console.ReadLine();

            while (input != "No Money")
            {
                string[] commands = input.Split();
                string command = commands[0];
                string gift = commands[1];

                if (command == "OutOfStock")
                {
                    for (int i = 0; i < gifts.Length; i++)
                    {
                        if (gifts[i] == gift)
                        {
                            gifts[i] = "None";
                        }
                    }
                }
                else if (command == "Required")
                {
                    int index = int.Parse(commands[2]);
                    if (index >= 0 && index < gifts.Length)
                    {
                        gifts[index] = gift;
                    }
                }
                else if (command == "JustInCase")
                {
                    gifts[gifts.Length - 1] = gift;
                }

                input = Console.ReadLine();
            }
            for (int i = 0; i < gifts.Length; i++)
            {
                if (gifts[i] != "None")
                {
                    Console.Write(gifts[i].Trim() + ' ');
                }
            }
            
        }
    }
}
