using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();

            while (text.IndexOf(word) > -1)
            {
                text = text.Remove(text.IndexOf(word), word.Length);
            }
            Console.WriteLine(text);
            text.Replace()
        }
    }
}
