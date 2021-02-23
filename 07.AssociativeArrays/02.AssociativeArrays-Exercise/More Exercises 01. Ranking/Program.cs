using System;
using System.Linq;
using System.Collections.Generic;

namespace More_Exercises_01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string command;
            int maxPoints = 0;
            string maxUser;
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Competition> users = new Dictionary<string, Competition>();

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] data = input.Split(':', StringSplitOptions.None);
                string contest = data[0];
                string password = data[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, password);
                }
            }

            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] inputArgs = command.Split("=>", StringSplitOptions.None);
                string cont = inputArgs[0];
                string pass = inputArgs[1];
                string username = inputArgs[2];
                int points = int.Parse(inputArgs[3]);

                if (contests.ContainsKey(cont)) //check if contest is valid
                {
                    if (contests[cont] == pass) //check if password is correct
                    {
                        //if user and contest in contests dictionary are the same
                        if (users.ContainsKey(username) && users[username].Contest.ContainsKey(cont))
                        {
                            //override the points if the points behind that key are less
                            if (users[username].Contest[cont] < points)
                            {
                                users[username].Contest[cont] = points;
                            }
                        }

                        //if user doesn't exist 
                        if (!users.ContainsKey(username))
                        {
                            Competition competition = new Competition(new Dictionary<string, int>());
                            users.Add(username, competition);
                        }
                        //if the user already exists -> add the competition and the points
                        else
                        {
                            users[username].Contest.Add(cont, points);
                        }
                    }


                }

            }

            foreach (var user in users)
            {
                int studentsPoints = user.Value.Contest.
                if (user.Value.Contest.Any(n=>n.Value > maxPoints))
                {

                }
            }

            users = users
                .OrderBy(u => u.Value.Contest)
                .ToDictionary(a=>a.Key, b=>b.Value);

            string bestCandidate = users.First(users.Key);


        }
    }

    public class Competition
    {
        public Dictionary<string, int> Contest { get; set; }

        public Competition(Dictionary<string, int> contest)
        {
            this.Contest = contest;
        }

    }
}
