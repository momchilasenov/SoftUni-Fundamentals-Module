using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MessagesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            Dictionary<string, Message> users = new Dictionary<string, Message>();

            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string[] commands = input.Split("=");
                string command = commands[0];

                if (command == "Add")
                {
                    string user = commands[1];
                    int sent = int.Parse(commands[2]);
                    int received = int.Parse(commands[3]);

                    if (!users.ContainsKey(user))
                    {
                        users.Add(user, new Message() { Sent = sent, Received = received });
                    }
                }
                else if (command == "Message")
                {
                    string sender = commands[1];
                    string receiver = commands[2];

                    if (users.ContainsKey(sender) && users.ContainsKey(receiver))
                    {
                        ProcessMessage(capacity, users, sender, receiver);
                    }
                }

                else if (command == "Empty")
                {
                    string username = commands[1];
                    RemoveUser(users, username);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Count}");

            var sorted = users
                .OrderByDescending(x => x.Value.Received)
                .ThenBy(n => n.Key)
                .ToList();

            foreach (var user in sorted)
            {
                int totalMessages = user.Value.Sent + user.Value.Received;
                Console.WriteLine($"{user.Key} - {totalMessages}");
            }

        }

        private static void ProcessMessage(int capacity, Dictionary<string, Message> users, string sender, string receiver)
        {
            users[sender].Sent++;
            users[receiver].Received++;

            int allSenderMessages = users[sender].Sent + users[sender].Received;

            if (allSenderMessages >= capacity)
            {
                DeleteUser(users, sender);
            }

            int allReceiverMessages = users[receiver].Sent + users[receiver].Received;

            if (allReceiverMessages >= capacity)
            {
                DeleteUser(users, receiver);
            }
        }

        private static void DeleteUser(Dictionary<string, Message> users, string user)
        {
            Console.WriteLine($"{user} reached the capacity!");
            users.Remove(user);
        }

        private static void RemoveUser(Dictionary<string, Message> users, string username)
        {
            if (username == "All")
            {
                users.Clear();
            }
            else
            {
                if (users.ContainsKey(username))
                {
                    users.Remove(username);
                }
            }
        }
    }

    public class Message
    {
        public int Sent { get; set; }
        public int Received { get; set; }
        public int Total => this.Sent + this.Received;
    }

}
