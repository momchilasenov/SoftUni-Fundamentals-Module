using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Pokemon_Don_t_Go_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int indexToRemove = int.Parse(Console.ReadLine());
            int valueOfPokemonToRemove = 0;
            int sumOfRemovedElements = 0;

            while (pokemons.Count > 0)
            {
                if (indexToRemove>=0 && indexToRemove <= pokemons.Count - 1)
                {
                    valueOfPokemonToRemove = pokemons[indexToRemove];
                    pokemons.RemoveAt(indexToRemove);
                    
                }
                else if (indexToRemove < 0)
                {
                    valueOfPokemonToRemove = pokemons[0];
                    pokemons.RemoveAt(0);
                    pokemons.Insert(0, pokemons[pokemons.Count - 1]);
                }
                else if (indexToRemove > pokemons.Count - 1)
                {
                    valueOfPokemonToRemove = pokemons[pokemons.Count - 1];
                    pokemons.Insert(pokemons.Count - 1, pokemons[0]);
                    pokemons.RemoveAt(pokemons.Count - 1);
                }
                
                sumOfRemovedElements += valueOfPokemonToRemove;
                if (pokemons.Count == 0)
                {
                    break;
                }

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= valueOfPokemonToRemove)
                    {
                        pokemons[i] += valueOfPokemonToRemove;
                    }
                    else if (pokemons[i] > valueOfPokemonToRemove)
                    {
                        pokemons[i] -= valueOfPokemonToRemove;
                    }
                }

                indexToRemove = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sumOfRemovedElements);
        }

     

    }
}
