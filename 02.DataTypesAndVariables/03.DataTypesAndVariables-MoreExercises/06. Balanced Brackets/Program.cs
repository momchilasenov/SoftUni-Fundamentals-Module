using System;

namespace More_Exercises___06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isUnbalanced = false;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                counter++;

                if (counter % 2 != 0)
                {
                    if (input != "(" && input!= ")")
                    {
                        isUnbalanced = true;
                    }
                }
            }
            if (isUnbalanced)
            {
                Console.WriteLine("UNBALANCED");
            }
            else
            {
                Console.WriteLine("BALANCED");
            }

        }
    }
}
