using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace _4._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            List<string> goodKids = new List<string>();

            while (input != "end")
            {
                char[] symbols = input.ToCharArray();
                StringBuilder decrypted = new StringBuilder();

                foreach (char letter in symbols)
                {
                    char currentLetter = (char)((int)letter - key);
                    decrypted.Append(currentLetter);
                }

                input = decrypted.ToString();

                string pattern = @"(?<=@)([A-Za-z]+)[^@!:>-]*!([GN])!";
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    if (match.Groups[2].Value == "G")
                    {
                        goodKids.Add(match.Groups[1].Value);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(Environment.NewLine, goodKids));
        }
    }
}
