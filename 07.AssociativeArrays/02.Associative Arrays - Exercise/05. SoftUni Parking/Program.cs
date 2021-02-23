using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parkingData = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string command = commands[0];
                string username = commands[1];

                if (command == "register")
                {
                    string licensePlate = commands[2];
                    if (parkingData.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                    else
                    {
                        parkingData.Add(username, licensePlate);
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }

                }
                else if (command == "unregister")
                {
                    if (parkingData.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        parkingData.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }
            foreach(var element in parkingData)
            {
                Console.WriteLine($"{element.Key} => {element.Value}");
            }
        }
    }
}
