using System;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();
            string word = string.Empty;
            string censoredWord = string.Empty;

            for (int i = 0; i < bannedWords.Length; i++)
            {
                word = bannedWords[i];
                censoredWord = new string('*', word.Length);

                while (text.IndexOf(word) > -1)
                {
                    text = text.Replace(word, censoredWord);
                }
            }
            Console.WriteLine(text);
        }
    }
}
