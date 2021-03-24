using System;
using System.Linq;

namespace _02._Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weaponArray = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] commands = input.Split().ToArray();
                string command = commands[0];
                string subcommand = commands[1];

                if (command == "Move")
                {
                    int index = int.Parse(commands[2]);

                    if (subcommand == "Left")
                    {
                        if (index >= 0 && index < weaponArray.Length && index - 1 >= 0 && index - 1 < weaponArray.Length)
                        {
                            string temp = weaponArray[index - 1];
                            weaponArray[index - 1] = weaponArray[index];
                            weaponArray[index] = temp;
                        }
                    }
                    else if (subcommand == "Right")
                    {
                        if (index >= 0 && index < weaponArray.Length && index + 1 >= 0 && index + 1 < weaponArray.Length)
                        {
                            string temp = weaponArray[index + 1];
                            weaponArray[index + 1] = weaponArray[index];
                            weaponArray[index] = temp;
                        }
                    }
                }
                else if (command == "Check")
                {
                    if (subcommand == "Even")
                    {
                        for (int i = 0; i < weaponArray.Length; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write(weaponArray[i] + " ");
                            }
                        }
                    }
                    else if (subcommand == "Odd")
                    {
                        for (int i = 0; i < weaponArray.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write(weaponArray[i] + " ");
                            }
                        }
                    }
                    Console.WriteLine();
                }
            }
            string weaponName = string.Join("", weaponArray);
            Console.WriteLine($"You crafted {weaponName}!");
        }
    }
}
