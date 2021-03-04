using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text = Console.ReadLine();
            StringBuilder stringBuild = new StringBuilder();

            int power = 0;

            for (int i=0; i<text.Length; i++)
            {
                char currentChar = text[i];
                
                if (currentChar == '>') //if you reach a bomb
                {
                    power += int.Parse(text[i + 1].ToString()); 
                    stringBuild.Append(currentChar); 
                }
                else if (power == 0) 
                {
                    stringBuild.Append(currentChar); 
                }
                else 
                {
                    power--; 
                }
            }
            Console.WriteLine(stringBuild);




        }
    }
}
