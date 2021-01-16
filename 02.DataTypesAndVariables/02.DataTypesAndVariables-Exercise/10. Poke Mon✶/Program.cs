using System;

namespace _10._Poke_Mon_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //pokePower of the pokemon
            int m = int.Parse(Console.ReadLine()); //distance between targets
            int y = int.Parse(Console.ReadLine()); //exhaustionFactor

            int originalValueOfN = n;
            int pokedTargets = 0;

            while (n >= m)
            {
                pokedTargets++;
                n -= m; //substract m from n until n<m

                if (n == 0.5 * originalValueOfN)
                {
                    if (y != 0)
                    {
                        n = n / y;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(pokedTargets);
        }
    }
}
