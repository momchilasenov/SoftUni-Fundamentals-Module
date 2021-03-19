using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();
            int currentTarget = 0;
            int shotsCount = 0;

            while (input?.ToUpper() != "END")
            {
                int index = int.Parse(input);

                if (index >= 0 && index < targets.Count() && index != -1) //if the index is within the array
                {
                    currentTarget = targets[index];
                    targets[index] = -1; //shooting the target
                    shotsCount++;

                    for (int i = 0; i < targets.Count(); i++)
                    {
                        if (targets[i] != -1)
                        {
                            if (targets[i] > currentTarget)
                            {
                                targets[i] -= currentTarget;
                            }
                            else if (targets[i] <= currentTarget)
                            {
                                targets[i] += currentTarget;
                            }
                        }
                        
                    }
                }

                input = Console.ReadLine();
            }
            Console.Write($"Shot targets: {shotsCount} -> ");
            Console.Write(String.Join(' ', targets));

        }
    }
}
