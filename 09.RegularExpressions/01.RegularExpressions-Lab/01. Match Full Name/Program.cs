using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st regex: [A-Z]{1}[a-z]* ?
            //2nd regex: \b[A-Z][a-z]+ [A-Z][a-z]+\b 

            string input = Console.ReadLine();

            Regex ownRegex = 
                new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            MatchCollection matches = ownRegex.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write(match.Value+" ");
            }

        }
    }
}
