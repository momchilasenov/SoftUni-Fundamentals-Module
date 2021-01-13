using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courseCount = (int)Math.Ceiling(numberOfPeople/(double)capacity);

            Console.WriteLine(courseCount);

            char symbol = '1';
            int number = symbol - '0'; //връща 1 




        }
    }
}
