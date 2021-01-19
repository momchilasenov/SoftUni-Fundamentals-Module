using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Solution
            string[] strings = Console.ReadLine().Split(); //1 2 3 4 5

            for (int i = 0; i < strings.Length / 2; i++) 
            {
                string temp = strings[i];
                strings[i] = strings[strings.Length - i - 1]; //5-1-1
                strings[strings.Length - i - 1] = temp;

            }
            Console.WriteLine(String.Join(" ", strings));

            //One row solution

            Console.WriteLine(string.Join(' ', Console.ReadLine()
                .Split()
                .Reverse()));
        }
    }
}
