using System;
using System.Text;

namespace _01.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Decode")
            {
                string[] commands = input.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];

                if (command == "Move")
                {
                    int numberOfLetters = int.Parse(commands[1]);
                    string substring = message.Substring(0, numberOfLetters);
                    message = message.Remove(0, numberOfLetters);
                    message = message + substring;
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(commands[1]);
                    string value = commands[2];
                    StringBuilder sb = new StringBuilder(message);
                    sb.Insert(index, value);
                    message = sb.ToString();
                }
                else if (command == "ChangeAll")
                {
                    string substring = commands[1];
                    string replacement = commands[2];
                    message = message.Replace(substring, replacement);
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
