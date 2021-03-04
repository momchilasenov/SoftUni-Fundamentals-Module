using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;


namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = Console.ReadLine();

            ////Agd#53Dfg^&4F53
            //List<char> numbers = new List<char>();
            //List<char> letters = new List<char>();
            //List<char> symbols = new List<char>();

            //for (int i = 0; i < text.Length; i++)
            //{
            //    char currentLetter = text[i];

            //    if ((int)currentLetter >= 48 && currentLetter <= 57)
            //    {
            //        numbers.Add(currentLetter);
            //    }
            //    else if ((int) currentLetter >= 65 && (int) currentLetter <= 90
            //        || (int)currentLetter >= 97 && (int)currentLetter <= 122)
            //    {
            //        letters.Add(currentLetter);
            //    }
            //    else
            //    {
            //        symbols.Add(currentLetter);
            //    }
            //}
            //Console.WriteLine(string.Join("", numbers));
            //Console.WriteLine(string.Join("", letters));
            //Console.WriteLine(string.Join("", symbols));

            //доста по-елегантно решение
            string text = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {

                if (char.IsDigit(text[i]))
                {
                    digits.Append(text[i]);
                }
                else if (char.IsLetter(text[i]))
                {
                    letters.Append(text[i]);
                }
                else
                {
                    symbols.Append(text[i]);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);

        }
    }
}
