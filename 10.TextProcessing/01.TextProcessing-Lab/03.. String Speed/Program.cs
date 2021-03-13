using System;
using System.Diagnostics;
using System.Text;

namespace _1._String_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 10000;
            Stopwatch watch = Stopwatch.StartNew();

            //string speed
            string stringResult = string.Empty;

            for (int i=0; i<times; i++)
            {
                stringResult += "text";
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            watch.Reset();

            //stringbuilder speed
            StringBuilder newText = new StringBuilder();
            for (int i=0; i<times; i++)
            {
                newText.Append("text");
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}
