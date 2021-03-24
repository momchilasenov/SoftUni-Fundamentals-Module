using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chatLogger = new List<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> commands = input.Split().ToList();
                string command = commands[0];
                string message = commands[1];

                if (command == "Chat")
                {
                    chatLogger.Add(message);
                }
                else if(command == "Delete")
                {
                    if (chatLogger.Contains(message))
                    {
                        chatLogger.Remove(message);
                    }
                }
                else if (command == "Edit")
                {
                    string editedVersion = commands[2];
                    chatLogger[chatLogger.IndexOf(message)] = editedVersion;
                }
                else if (command == "Pin")
                {
                    int indexOfMessage = chatLogger.IndexOf(message);
                    chatLogger.RemoveAt(indexOfMessage);
                    chatLogger.Add(message);
                }
                else if (command == "Spam")
                {
                    commands.Remove("Spam");
                    chatLogger.AddRange(commands);
                }

            }

            Console.WriteLine(String.Join(Environment.NewLine, chatLogger));
        }
    }
}
