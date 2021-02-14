using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Random rnd = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int randomNumber = rnd.Next(0, words.Count);
                string word = words[i];
                words[i] = words[randomNumber];
                words[randomNumber] = word;
            }
            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
    }
}

