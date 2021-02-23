using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_Exam_Results_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();

            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }
                                
                string[] data = input.Split('-', StringSplitOptions.RemoveEmptyEntries);

                if (data[1] == "banned")
                {
                    string userToBan = data[0];
                    students.Remove(userToBan);
                    continue;
                }

                string username = data[0];
                string language = data[1];
                int points = int.Parse(data[2]);

                //students+points logic
                if (students.ContainsKey(username))
                {
                    if (students[username] < points)
                    {
                        students[username] = points;
                    }
                }
                else
                {
                    students.Add(username, points);
                }

                //submissions logic
                if (submissions.ContainsKey(language))
                {
                    submissions[language]++;
                }
                else
                {
                    submissions.Add(language, 1);
                }
            }
            Console.WriteLine("Results:");
            
            foreach (var student in students.OrderByDescending(x=>x.Value).ThenBy(n=>n.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var language in submissions.OrderByDescending(x => x.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
