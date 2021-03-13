using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine())!= "Generate")
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
                    int startIndex = int.Parse(commands[2]);
                    int endIndex = int.Parse(commands[3]);

                    if (commands[1] == "Upper")
                    {
                        activationKey = (activationKey.Substring(0, startIndex)) + (activationKey.Substring(startIndex, endIndex - startIndex).ToUpper()) + activationKey.Substring(endIndex, activationKey.Length - endIndex);
                                                
                    }
                    else if (commands[1] == "Lower")
                    {
                        activationKey = (activationKey.Substring(0, startIndex)) + (activationKey.Substring(startIndex, endIndex - startIndex).ToLower()) + activationKey.Substring(endIndex, activationKey.Length - endIndex);
                        
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
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
