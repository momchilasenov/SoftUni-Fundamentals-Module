using System;

namespace _0._Word_Founder
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample input: 
            //word == mom 
            //text == mom help mom mom hey help mom

            string word = Console.ReadLine();
            string text = Console.ReadLine();

            int currentIndex = 0;

            while (text.IndexOf(word, currentIndex) > -1) //it only finds the word you need
            {
                currentIndex = text.IndexOf(word, currentIndex) + 1;
                Console.WriteLine($"{word} found at {currentIndex} position");
            }
        }
    }
}
