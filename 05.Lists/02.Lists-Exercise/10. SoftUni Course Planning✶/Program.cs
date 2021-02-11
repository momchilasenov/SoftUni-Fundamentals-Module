using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_Course_Planning_
{
    class Program
    {
        static void Main(string[] args)
        {
            //read initial schedule lessons
            List<string> lessons = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] commands = input.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];
                string lessonTitle = commands[1];

                if (command == "Add")
                {
                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Add(lessonTitle);
                    }
                }
                else if (command == "Insert")
                {
                    if (!lessons.Contains(lessonTitle))
                    {
                        int index = int.Parse(commands[2]);
                        lessons.Insert(index, lessonTitle);
                    }
                }
                else if (command == "Remove")
                {
                    if (lessons.Contains(lessonTitle))
                    {
                        lessons.Remove(lessonTitle);
                        string exercise = lessonTitle + "-Exercise";
                        if (lessons.Contains(exercise))
                        {
                            lessons.Remove(exercise);
                        }
                    }

                }
                else if (command == "Swap")
                {
                    string secondLesson = commands[2];
                    string exerciseOne = lessonTitle + "-Exercise";
                    string exerciseTwo = secondLesson + "-Exercise";
                    
                    if (lessons.Contains(lessonTitle) && lessons.Contains(secondLesson))
                    {
                        int swapOne = lessons.IndexOf(lessonTitle);  //0
                        int swapTwo = lessons.IndexOf(secondLesson); //2

                        string temp = lessons[swapOne];
                        lessons[swapOne] = lessons[swapTwo];
                        lessons[swapTwo] = temp;

                        if (lessons.Contains(exerciseOne))
                        {
                            lessons.Remove(exerciseOne);
                            lessons.Insert(lessons.IndexOf(lessonTitle)+1, exerciseOne);
                        }
                        else if (lessons.Contains(exerciseTwo))
                        {
                            lessons.Remove(exerciseTwo);
                            lessons.Insert(lessons.IndexOf(secondLesson)+1, exerciseTwo);
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    string exercise = lessonTitle + "-Exercise";
                    if (lessons.Contains(lessonTitle) && !lessons.Contains(exercise))
                    {
                        int index = lessons.IndexOf(lessonTitle);
                        lessons.Insert(index + 1, exercise);
                    }
                    else if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Add(lessonTitle);
                        lessons.Add(exercise);
                    }
                }
            }
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i+1}.{lessons[i]}");
            }
        }
    }
}
