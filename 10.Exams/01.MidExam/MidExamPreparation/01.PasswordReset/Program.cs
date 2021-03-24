using System;
using System.Text;

namespace _01.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input = string.Empty;

            StringBuilder sbPassword = new StringBuilder();

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] commands = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];

                if (command == "TakeOdd")
                {
                    for (int i = 1; i < password.Length; i += 2)
                    {
                        sbPassword.Append(password[i]);
                    }
                    password = sbPassword.ToString();

                    Console.WriteLine(password);
                }

                else if (command == "Cut")
                {
                    int index = int.Parse(commands[1]);
                    int length = int.Parse(commands[2]);

                    password = password.Remove(index, length);

                    Console.WriteLine(password);
                }
                else if (command == "Substitute")
                {
                    string substring = commands[1];
                    string substitute = commands[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

            }
            Console.WriteLine($"Your password is: {password}");

        }
    }
}
