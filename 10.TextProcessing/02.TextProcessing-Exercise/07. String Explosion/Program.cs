using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. read the input string 
            //1.1. create a stringBuilder to modify the string
            //2. start going through each char in the SB
            //2.1. if you find '>' get the current index
            //2.2. get the strength = currentIndex + 1 (NOTE: can strength be 0? and what if?)
            //3. with a for loop start removing characters one by one from the index of '>' forward
            //3.1. before each iteration check if you have another '>' char on the following position
            //3.2. if you find '>' - take remaining power and add it to the new strength 
            //4. convert the sb to string and print the resulting string
            //note - what happens when the explosion is too big?

            //string input = Console.ReadLine();
            //StringBuilder sb = new StringBuilder(input);

            //int strength = 0;
            //int leftStrength = 0;

            //for (int currIndex = 0; currIndex < sb.Length - 1; currIndex++)
            //{
            //    if (sb[currIndex] == '>')
            //    {
            //        strength = (int.Parse(sb[currIndex + 1].ToString()))+leftStrength;
            //        leftStrength = strength;

            //        for (int j = 1; j <= strength; j++)
            //        {
            //            if (currIndex + 1 >= sb.Length)
            //            {
            //                break;
            //            }

            //            if (sb[currIndex + 1] == '>')
            //            {
            //                break;
            //            }

            //            sb.Remove(currIndex + 1, 1);
            //            leftStrength--;
            //        }
            //    }
            //}
            //string result = sb.ToString();
            //Console.WriteLine(result);

            //Решение с append към SB
            string text = Console.ReadLine();
            StringBuilder stringBuild = new StringBuilder();

            int power = 0;

            for (int i=0; i<text.Length; i++)
            {
                char currentChar = text[i];
                
                if (currentChar == '>') //if you reach a bomb
                {
                    power += int.Parse(text[i + 1].ToString()); //get the total current power
                    stringBuild.Append(currentChar); //we add the char before the bomb power
                }
                else if (power == 0) //if you don't have a power and this is not a '>' - append it 
                {
                    stringBuild.Append(currentChar); 
                }
                else //for as long as you have some power and the char is not '>' -> Don't append!
                {
                    power--; //if you reach the bomb power decrease it's power by one and DON'T append
                }
            }
            Console.WriteLine(stringBuild);




        }
    }
}
