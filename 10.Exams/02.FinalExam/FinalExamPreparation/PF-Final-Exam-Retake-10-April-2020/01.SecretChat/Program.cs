using System;
using System.Text;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != "Reveal")
            {
                string[] commands = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(commands[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (command == "Reverse")
                {
                    string substring = commands[1];
                    StringBuilder sb = new StringBuilder(substring);
                    StringBuilder messageSB = new StringBuilder(message);
                    if (message.Contains(substring))
                    {
                        messageSB = messageSB.Remove(message.IndexOf(substring), substring.Length);
                        for (int i = 0; i < sb.Length / 2; i++)
                        {
                            char temp = sb[i];
                            sb[i] = sb[sb.Length -i- 1];
                            sb[sb.Length - i - 1] = temp;

                        }
                        substring = sb.ToString();
                        messageSB = messageSB.Append(substring);
                        message = messageSB.ToString();
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (command == "ChangeAll")
                {
                    string substring = commands[1];
                    string replacement = commands[2];
                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
