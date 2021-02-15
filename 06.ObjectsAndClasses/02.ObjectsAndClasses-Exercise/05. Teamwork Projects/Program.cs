using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 1; i <= numberOfTeams; i++)
            {
                string[] info = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string creator = info[0];
                string teamName = info[1];

                if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team(teamName, creator);
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }
            
            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] inputs = input
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string member = inputs[0];
                string teamToJoin = inputs[1];

                if (!teams.Any(x => x.TeamName == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    continue;
                }
                if (teams.Any(x=>x.Members.Contains(member)) || teams.Any(x=>x.Creator==member && x.TeamName == teamToJoin))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamToJoin}!");
                    continue;
                }

                int index = teams.FindIndex(x => x.TeamName == teamToJoin);
                teams[index].Members.Add(member); 
            }

            List<Team> teamsToDisband = teams
                .FindAll(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            List<Team> validTeams = teams
                .FindAll(x => x.Members.Count > 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            Console.WriteLine(String.Join(Environment.NewLine,
                validTeams
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)));


            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine(team.TeamName);
            }
        }

    }
    public class User
    {
        public string Name { get; set; }
        public string TeamToJoin { get; set; }
    }

    public class Team
    {
        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Members;

        public Team(string teamName, string creator)
        {
            Members = new List<string>();
            this.Creator = creator;
            this.TeamName = teamName;
        }

        public override string ToString()
        {
            StringBuilder buildString = new StringBuilder(); 
            buildString.AppendLine(TeamName);
            buildString.AppendLine("- " + Creator);

            foreach(var member in Members)
            {
                buildString.AppendLine("-- " + member);
            }

            return buildString.ToString().TrimEnd();
        }
    }
}



