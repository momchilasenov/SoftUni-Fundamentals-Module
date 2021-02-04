using System;

namespace More_Exercises_01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st - with one method - one overload
            //string dataType = Console.ReadLine();
            //string input = Console.ReadLine();
            //FindDataType(dataType, input);

            //2nd - one method different overloads
            string dataType = Console.ReadLine();
            string input = Console.ReadLine();

            if (dataType == "int")
            {
                int num = int.Parse(input);
                FindDataType(num);
            }
            else if (dataType == "double")
            {
                double realNum = double.Parse(input);
                FindDataType(realNum);
            }
            else if (dataType == "string")
            {
                FindDataType(input);
            }


        }

        //static void FindDataType (string dataType, string input)
        //{
        //    if (dataType == "int")
        //    {
        //        int result = int.Parse(input);
        //        Console.WriteLine(result * 2);
        //    }
        //    else if (dataType == "real")
        //    {
        //        double result = double.Parse(input);
        //        Console.WriteLine($"{result*1.5:f2}");
        //    }
        //    else if (dataType == "string")
        //    {
        //        input = "$" + input + "$";
        //        Console.WriteLine(input);
        //    }
        //}

        static void FindDataType (int num)
        {
            Console.WriteLine(num*2);
        }
        static void FindDataType(double realNum)
        {
            Console.WriteLine($"{realNum * 1.5:f2}");
        }
        static void FindDataType (string input)
        {
            input = "$" + input + "$";
            Console.WriteLine(input);
        }


    }
}
