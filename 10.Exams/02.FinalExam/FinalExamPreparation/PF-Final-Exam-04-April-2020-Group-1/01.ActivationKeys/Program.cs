using System;
using System.Text;

namespace _01.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != "Generate")
            {
                string[] commands = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];

                if (command == "Contains")
                {
                    string substring = commands[1];
                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                else if (command == "Flip")
                {
                    string modify = commands[1];
                    int startIndex = int.Parse(commands[2]);
                    int endIndex = int.Parse(commands[3]);

                    if (modify == "Upper")
                    {
                        string substring = activationKey.Substring(startIndex, endIndex - startIndex);
                        string replacement = substring.ToUpper();
                        activationKey = activationKey.Replace(substring, replacement);

                    }
                    else if (modify == "Lower")
                    {
                        string substring = activationKey.Substring(startIndex, endIndex - startIndex);
                        string replacement = substring.ToLower();
                        activationKey = activationKey.Replace(substring, replacement);
                    }
                    Console.WriteLine(activationKey);
                }

                else if (command == "Slice")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
