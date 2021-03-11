using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;

namespace More_Exercises_3._Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPattern = @"(?<=([#$%*&]){1})([A-Z]+)(?=\1)";
            string secondPattern = @"(\d+):(\d{2})";
            string thirdPattern = @"(?:\|.*)\|(.*)";

            string input = Console.ReadLine();

            Match match = Regex.Match(input, firstPattern);
            MatchCollection secondMatches = Regex.Matches(input, secondPattern);
            Match thirdMatches = Regex.Match(input, thirdPattern);

            Dictionary<char, int> lettersDictionary = new Dictionary<char, int>();

            if (match.Success)
            {
                char[] letters = match.Groups[2].Value.ToCharArray();

                for (int i = 0; i < match.Length; i++)
                {
                    int currentCode = (int)letters[i];
                    char currentLetter = letters[i];

                    foreach (Match number in secondMatches)
                    {
                        int code = int.Parse(number.Groups[1].Value);
                        int wordLength = int.Parse(number.Groups[2].Value) + 1;
                        if (currentCode == code)
                        {
                            lettersDictionary.Add(currentLetter, wordLength);
                            break;
                        }
                    }
                }

                if (thirdMatches.Success)
                {
                    string[] words = thirdMatches
                        .Groups[1]
                        .Value
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    char[] enumerator = lettersDictionary.Keys.ToArray();

                    for (int i = 0; i < lettersDictionary.Count; i++)
                    {
                        char currentLetter = enumerator[i];
                        int length = lettersDictionary[currentLetter];

                        for (int j = 0; j < words.Length; j++)
                        {
                            string currentWord = words[j];
                            char firstLetter = currentWord[0];
                            int currentLength = currentWord.Length;

                            if (firstLetter == currentLetter && currentLength == length)
                            {
                                Console.WriteLine(currentWord);
                            }
                        }

                    }
                }
            }
        }
    }
}
