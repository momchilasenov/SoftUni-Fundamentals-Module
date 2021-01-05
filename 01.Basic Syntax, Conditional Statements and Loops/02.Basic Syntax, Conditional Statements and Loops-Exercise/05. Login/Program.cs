using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine(); // baby
            string password = Console.ReadLine();
            string reversedUsername = "";
            int counter = 0;

            for (int i = username.Length - 1; i>=0; i--)
            {
                reversedUsername += username[i];
            }

            while (true)
            {
                if (password != reversedUsername)
                {
                    counter++;
                    if (counter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break; ;
                    }

                    Console.WriteLine("Incorrect password. Try again.");
                    password = "";

                   
                }
                else if (password == reversedUsername)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                password = Console.ReadLine();

            }

        }
    }
}
