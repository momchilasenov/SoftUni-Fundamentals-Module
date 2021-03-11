using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern 
                = @"%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|(\w+)\|[^|$%.]*?(\d+\.?\d*)\$";

            string input = Console.ReadLine();
            double totalPrice = 0;

            while (input != "end of shift")
            {
                double price = 0;
                string name = string.Empty;
                string product = string.Empty;

                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);
                if (match.Success)
                {
                    price = double.Parse(match.Groups[3].Value) * double.Parse(match.Groups[4].Value);
                    name = match.Groups[1].Value;
                    product = match.Groups[2].Value;
                    Console.WriteLine($"{name}: {product} - {price:f2}");
                    totalPrice += price;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
