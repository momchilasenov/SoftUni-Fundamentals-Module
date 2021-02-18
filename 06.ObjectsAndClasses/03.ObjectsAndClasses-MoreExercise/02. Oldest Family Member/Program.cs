using System;
using System.Linq;
using System.Collections.Generic;

namespace More_Exercises_02._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                Family.AddMember(input);
            }
        }
    }

    public class Family
    {
        public List<Person> people = new List<Person>();
        public static void AddMember(string input)
        {
            string[] member = input.Split().ToArray();
            string name = member[0];
            int age = int.Parse(member[1]);

            Person newMember = new Person(name, age);
            people.Add(Person.newMember);
        }

        public void GetOldestMember()
        {

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
