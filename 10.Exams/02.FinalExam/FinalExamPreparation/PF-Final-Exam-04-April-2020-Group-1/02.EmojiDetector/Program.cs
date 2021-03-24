using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string emojiPattern = @"([:]{2}|[*]{2})([A-Z]{1}[a-z]{2,})\1";
            string numbersPattern = @"[0-9]";

            string input = Console.ReadLine();
            long coolThreshold = 1;
            int emojiCounter = 0;
            long emojiCoolness = 0;

            Dictionary<string,long> coolEmojis = new Dictionary<string, long>();

            MatchCollection matches = Regex.Matches(input, numbersPattern);
            MatchCollection emojiMatches = Regex.Matches(input, emojiPattern);

            foreach(Match number in matches)
            {
                coolThreshold *= int.Parse(number.Value);
            }

            foreach(Match emoji in emojiMatches)
            {
                emojiCounter++;
                string emojiName = emoji.Groups[2].Value;

                char[] currentEmoji = emoji.Groups[2].Value.ToCharArray();

                foreach (char letter in currentEmoji)
                {
                    emojiCoolness += (int)letter;
                }

                if (emojiCoolness > coolThreshold)
                {
                    coolEmojis.Add(emoji.Value, emojiCoolness);
                }

                emojiCoolness = 0;
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emojiCounter} emojis found in the text. The cool ones are:");
            foreach(var cool in coolEmojis)
            {
                Console.WriteLine(cool.Key);
            }
            
        }
    }
}
