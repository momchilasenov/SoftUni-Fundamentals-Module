using System;
using System.Text.RegularExpressions;
using System.Text;

namespace _02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string pattern = @"(?<=@)(?:#*)([A-Z][A-Za-z0-9]{4,}[A-Z])@#+";
            string numbersPattern = @"[0-9]";

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                StringBuilder productGroup = new StringBuilder();

                Match match = Regex.Match(input, pattern);
                MatchCollection matches = Regex.Matches(input, numbersPattern);

                if (match.Success)
                {
                    if (matches.Count != 0)
                    {
                        foreach (var digit in matches)
                        {
                            productGroup.Append(digit);
                        }
                        Console.WriteLine($"Product group: {productGroup}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
