using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Прочитаме лист от стрингове като сплитваме по | 
            //List<string> numbers = Console.ReadLine()
            //    .Split("|") //намери ли | се обособява нов елемент 
            //    .ToList() ;

            ////обръщаме листа наобратно
            //numbers.Reverse();

            ////Създаваме нов лист където да налеем елементите
            //List<string> result = new List<string>();

            ////създаваме цикъл с който да итерираме през всеки елемент и да го налеем в новия лист
            //foreach(string currentElement in numbers)
            //{
            //    string[] elements = currentElement
            //        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //        .ToArray(); //махаме спейсовете от отделните числа

            //    foreach(string element in elements) //итерираме по всеки елемент в масива от елементи
            //    {
            //        result.Add(element);
            //    }
            //}
            //Console.WriteLine(String.Join(' ', result));

            List<string> numbers = Console.ReadLine()
                .Split('|')
                .ToList();

            numbers.Reverse();

            List<string> newList = new List<string>();

            foreach (string currentElement in numbers)
            {
                string[] elements = currentElement.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string element in elements)
                {
                    newList.Add(element);
                }
            }
            Console.WriteLine(String.Join(' ', newList));





        }
    }
}
