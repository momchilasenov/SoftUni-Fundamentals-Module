using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();

            string input = Console.ReadLine();
            double moneySum = 0;
            double totalSum = 0;
            string pattern = @">>(?<product>[A-z]+)<<(?<price>\d+|\d+\.\d*)!(?<quantity>\d+\b)";

            while (input != "Purchase")
            {
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);

                if (match.Success)
                {
                    if (int.Parse(match.Groups[3].Value) > 0)
                    {
                        products.Add(match.Groups[1].Value);
                        totalSum += double.Parse(match.Groups[2].Value) * int.Parse(match.Groups[3].Value);

                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            if (totalSum > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, products));
            }
            Console.WriteLine($"Total money spend: {totalSum:f2}");


        }
    }
}
