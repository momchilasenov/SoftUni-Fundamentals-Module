using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repetitions = int.Parse(Console.ReadLine());
            string result = RepeatedString(input, repetitions);
            Console.WriteLine(result);

        }

        static string RepeatedString (string input, int repetitions)
        {
            StringBuilder result = new StringBuilder();
            for (int i= 1; i<=repetitions; i++)
            {
                result.Append(input);
            }

            return result.ToString();
        }
    }
}
