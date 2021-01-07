using System;

namespace More_Exercises___02._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine(); //512
            int lastNumber = 0;
            int length = number.Length; //3         

            for (int i = length - 1; i >= 0;)
            {
                lastNumber = int.Parse(number[i].ToString());
                break;
            }

            switch (lastNumber)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 0:
                    Console.WriteLine("zero");
                    break;
            }

        }
    }
}
