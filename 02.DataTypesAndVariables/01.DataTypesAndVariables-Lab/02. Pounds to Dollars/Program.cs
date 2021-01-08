using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.31
            int pounds = int.Parse(Console.ReadLine());
            decimal dollars = pounds * 1.31M;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
