using System;

namespace More_Ex.___01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string dataType = "";
            int integer = 0;
            float floatingPoint = 0;

            while (input != "END")
            {
                int length = input.Length;
                if (int.TryParse(input, out integer))
                {
                    dataType = "integer";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if (float.TryParse(input, out floatingPoint))
                {
                    dataType = "floating point";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if (length == 1)
                {
                    dataType = "character";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if (input == "true" || input == "false")
                {
                    dataType = "boolean";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else
                {
                    dataType = "string";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                input = Console.ReadLine();
            }
        }
    }
}
