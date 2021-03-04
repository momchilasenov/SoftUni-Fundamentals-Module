using System;
using System.Linq;
using System.Collections.Generic;


namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> chars = new Dictionary<string, int>();

            foreach (string word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (chars.ContainsKey(word[i].ToString()))
                    {
                        chars[word[i].ToString()]++;
                    }
                    else
                    {
                        chars.Add(word[i].ToString(), 1);
                    }
                }
            }
            foreach (var element in chars)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }

        }
    }
}
