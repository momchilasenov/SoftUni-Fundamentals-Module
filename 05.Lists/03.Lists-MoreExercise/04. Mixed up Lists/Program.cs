using System;
using System.Linq;
using System.Collections.Generic;

namespace More_Exercises_04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 1; i <= Math.Min(arr1.Count, arr2.Count); i++)
            {
                int currentArr1Element = arr1[i - 1];
                int currentArr2Element = arr2[arr2.Count - i];
                result.Add(currentArr1Element);
                result.Add(currentArr2Element);
            }

            int firstConstraint = 0;
            int secondConstraint = 0;

            if (arr1.Count > arr2.Count)
            {
                firstConstraint = arr1[arr1.Count - 1];
                secondConstraint = arr1[arr1.Count - 2];
            }
            else
            {
                firstConstraint = arr2[0];
                secondConstraint = arr2[1];
            }

            List<int> finalList = new List<int>();

            foreach (int element in result
                .Where(x => x > Math.Min(firstConstraint, secondConstraint) && x< Math.Max(firstConstraint,secondConstraint)))
            {
                finalList.Add(element);
            }

            finalList = finalList.OrderBy(x => x).ToList();
            Console.WriteLine(String.Join(' ',finalList));




        }

    }
}

