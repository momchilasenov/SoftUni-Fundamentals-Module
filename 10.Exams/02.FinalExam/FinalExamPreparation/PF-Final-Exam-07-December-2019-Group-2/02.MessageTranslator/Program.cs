using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _02.MessageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                string pattern = @"!([A-Z]{1}[a-z]{2,})!:\[([A-Za-z]{8,})\]";

                List<int> nums = new List<int>();

                Match match = Regex.Match(message, pattern);

                if (match.Success)
                {
                    string command = match.Groups[1].Value;
                    string textToEncrypt = match.Groups[2].Value;

                    //1st solution
                    //foreach (char letter in textToEncrypt)
                    //{
                    //    if (char.IsLetter(letter))
                    //    {
                    //        nums.Add((int)letter);
                    //    }
                    //}
                    //Console.Write($"{command}: ");
                    //Console.Write(string.Join(' ', nums));

                    //2nd solution
                    int[] result = textToEncrypt
                        .Select(x => (int)x) //parse all chars to int ascii value
                        .ToArray(); //put all results in an array of integers

                    Console.WriteLine($"{command}: {string.Join(' ', result)}");


                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }


            }

        }
    }
}
