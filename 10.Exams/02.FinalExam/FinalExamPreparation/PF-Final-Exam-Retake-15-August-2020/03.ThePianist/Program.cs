using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] musicData = input.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string piece = musicData[0];
                string composer = musicData[1];
                string key = musicData[2];

                if (!pieces.ContainsKey(piece))
                {
                    pieces.Add(piece, new Piece() { Composer = composer, Key = key });
                }

            }

            string token = Console.ReadLine();

            while (token != "Stop")
            {
                string[] commands = token.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];
                string piece = commands[1];

                if (command == "Add")
                {
                    string composer = commands[2];
                    string key = commands[3];
                    
                    if (pieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        pieces.Add(piece, new Piece() { Composer = composer, Key = key });
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }
                
                else if (command == "Remove")
                {
                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                else if (command == "ChangeKey")
                {
                    string newKey = commands[2];

                    if (pieces.ContainsKey(piece))
                    {
                        pieces[piece].Key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                
                token = Console.ReadLine();
            }

            var sorted = pieces
                .OrderBy(n => n.Key)
                .ThenBy(p => p.Value.Composer)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var piece in sorted)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
            }
        }
    }

    public class Piece
    {
        public string Composer { get; set; }

        public string Key { get; set; }
    }
}
