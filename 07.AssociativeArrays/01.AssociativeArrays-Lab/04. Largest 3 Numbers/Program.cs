using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();

            int[] sorted = numbers.OrderByDescending(x => x).ToArray();

            int count = numbers.Length >= 3 ? 3 : numbers.Length;
                

            for (int i = 0; i < sorted.Length; i++)
            {
                while (i <= 2)
                {
                    Console.Write(sorted[i] + " ");
                    break;
                }
            }

            //Решение на 2 редa
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToList();

            Console.WriteLine(String.Join(' ', nums));

            ////Решение на 1 ред
            //Console.ReadLine() //прочитаме входните данни на 1 ред
            //    .Split()       //сплитваме ги по интервал
            //    .Select(int.Parse) //селектираме всеки елемент и го парсваме в число
            //    .OrderByDescending(n => n) //подреждаме ги в низходящ ред
            //    .ToList()                  //превръщаме всичко в Лист 
            //    .ForEach(n =>              //вече за всеки елемент в Листа принтираме
            //    {
            //        Console.WriteLine(String.Join(' ', n));
            //    });
        }
    }
}
