using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Person> people = new List<Person>();

            while((input = Console.ReadLine()) != "End")
            {
                string[] inputs = input.Split();
                string name = inputs[0];
                string id = inputs[1];
                int age = int.Parse(inputs[2]);

                Person person = new Person(name, id, age);
                people.Add(person);

            }
            people = people.OrderBy(x => x.Age).ToList();
            foreach(Person person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
    }
}
