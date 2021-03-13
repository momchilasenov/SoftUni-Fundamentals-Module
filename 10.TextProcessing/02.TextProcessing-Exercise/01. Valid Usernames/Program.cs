using System;
using System.Linq;
using System.Text;


namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(", ", StringSplitOptions.None)
                .ToArray();

            for (int i = 0; i < names.Length; i++)
            {
                string currentWord = names[i];

                if (currentWord.Length >= 3 && currentWord.Length <= 16)
                {
                    //check if each char meets the conditions
                    for (int j = 0; j < currentWord.Length; j++)
                    {
                        char currentChar = currentWord[j];

                        if (char.IsDigit(currentChar)
                            ||char.IsLetter(currentChar)
                            || currentChar == '-' 
                            || currentChar == '_')
                        {
                            if (j == currentWord.Length - 1)
                            {
                                Console.WriteLine(currentWord);
                            }
                            continue;
                            
                        }
                        else
                        {
                            break;
                        }
                        
                    }
                }
            }


        }
    }
}
