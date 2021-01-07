using System;

namespace More_Exercises___01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int largest = Math.Max(Math.Max(n1, n2), n3);

            if (largest == n1)
            {
                Console.WriteLine(n1);
                Console.WriteLine(Math.Max(n2,n3));
                Console.WriteLine(Math.Min(n2,n3));
            }
            else if (largest == n2)
            {
                Console.WriteLine(n2);
                Console.WriteLine(Math.Max(n1, n3));
                Console.WriteLine(Math.Min(n1, n3));
            }
            else if (largest == n3)
            {
                Console.WriteLine(n3);
                Console.WriteLine(Math.Max(n2, n3));
                Console.WriteLine(Math.Min(n2, n3));
            }
        }
    }
}
