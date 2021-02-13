using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace More_Exercises_03._Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string message = Console.ReadLine();
            List<string> numbersList = new List<string>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            List<string> result = new List<string>();
            StringBuilder nonNumbers = new StringBuilder();
            StringBuilder takeSymbol = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsDigit(message[i]))
                {
                    numbersList.Add(message[i].ToString());
                }
                else
                {
                    nonNumbers.Append(message[i], 1);
                }

            }
            List<int> num = numbersList
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < num.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(num[i]);
                }
                else
                {
                    skipList.Add(num[i]);
                }
            }

            for (int i = 0; i < takeList.Count; i++)
            {
                if (takeList[i] > nonNumbers.Length)
                {
                    takeList[i] = nonNumbers.Length;
                }
                takeSymbol.Append(nonNumbers, 0, takeList[i]);
                nonNumbers.Remove(0, takeList[i]);

                if (nonNumbers.Length > 0)
                {
                    nonNumbers.Remove(0, skipList[i]);
                }
            }

            Console.WriteLine(takeSymbol);
        }
    }
}
