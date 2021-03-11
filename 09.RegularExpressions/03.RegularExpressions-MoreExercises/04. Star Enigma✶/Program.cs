using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace _04._Star_Enigma_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string message = string.Empty;

            string lettersPattern = @"[starSTAR]";
            int attackedCount = 0;
            int destroyedCount = 0;
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 0; i < n; i++)
            {
                message = Console.ReadLine();
                int lettersCount = 0;
                Regex regex = new Regex(lettersPattern);
                MatchCollection matches = regex.Matches(message);

                foreach (Match letter in matches)
                {
                    lettersCount++;
                }

                StringBuilder sb = new StringBuilder(message);
                StringBuilder decrypted = new StringBuilder();
                for (int j = 0; j < sb.Length; j++)
                {
                    sb[j] = (char)((int)sb[j] - lettersCount);
                    decrypted.Append(sb[j]);
                }
                string newMessage = decrypted.ToString();

                string pattern = @"[^@!:>-]*@([A-Za-z]+)[^@!:>-]*:(\d+)[^@!:>-]*!(A|D)![^@!:>-]*->(\d+)[^@!:>-]*";

                Regex newRegex = new Regex(pattern);
                Match match = newRegex.Match(newMessage);
                if (match.Success)
                {
                    if (match.Groups[3].Value == "A")
                    {
                        attackedCount++;
                        attacked.Add(match.Groups[1].Value);
                    }
                    else if (match.Groups[3].Value == "D")
                    {
                        destroyedCount++;
                        destroyed.Add(match.Groups[1].Value);
                    }
                }
            }
            attacked = attacked.OrderBy(x => x).ToList();
            destroyed = destroyed.OrderBy(x => x).ToList();

            Console.WriteLine($"Attacked planets: {attackedCount}");
            foreach(string planet in attacked)
            {
                Console.WriteLine("-> " + planet);
            }

            Console.WriteLine($"Destroyed planets: {destroyedCount}");
            foreach (string planet in destroyed)
            {
                Console.WriteLine("-> " + planet);
            }


        }
    }
}

