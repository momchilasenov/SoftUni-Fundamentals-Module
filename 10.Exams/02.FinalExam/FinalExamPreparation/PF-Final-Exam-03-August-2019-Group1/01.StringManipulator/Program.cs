using System;

namespace _01.StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string token = Console.ReadLine();

            while (token != "End")
            {
                string[] commands = token.Split();
                string command = commands[0];

                if (command == "Translate")
                {
                    string oldString = commands[1];
                    string newString = commands[2];

                    message = message.Replace(oldString, newString);
                    Console.WriteLine(message);
                }
                else if (command == "Includes")
                {
                    string text = commands[1];
                    string result = message.Contains(text) ? "True" : "False";
                    Console.WriteLine(result);
                }
                else if (command == "Start")
                {
                    string text = commands[1];

                    //1st option
                    //string substring = message.Substring(0, text.Length);
                    //Console.WriteLine(text == substring ? "True" : "False");
                    
                    //2nd option 
                    Console.WriteLine(message.StartsWith(text) ? "True" : "False");

                }
                else if (command == "Lowercase")
                {
                    message = message.ToLower();
                    Console.WriteLine(message);
                }
                else if (command == "FindIndex")
                {
                    char letter = char.Parse(commands[1]);
                    int index = message.LastIndexOf(letter);
                    Console.WriteLine(index);
                }
                else if (command == "Remove")
                {
                    int startIndex = int.Parse(commands[1]);
                    int count = int.Parse(commands[2]);
                    message = message.Remove(startIndex, count);
                    Console.WriteLine(message);
                }

                token = Console.ReadLine();

            }
        }
    }
}
