using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            CountVowels(text);
        }      

        static void CountVowels(string text)
        {
            int vowelsCounter = 0;
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' }; //масив за всички главни букви

            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i])) //ако в масивът vowels се съдържат гласни букви 
                {
                    vowelsCounter++;
                }
            }
            Console.WriteLine(vowelsCounter);
        }
    }
}
