using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] array1 = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();

            foreach (string array2Item in array2) //за всеки елемент от масив 2
            {
                foreach (string array1Item in array1) //сравни го с всеки елемент от масив 1
                {
                    if (array2Item == array1Item) //и ако има сходство
                    {
                        Console.Write($"{array2Item} "); //принтирай резултата
                    }
                }
            }
        }
    }
}
