using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace _03ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPieces = int.Parse(Console.ReadLine());

            var pieces = new Dictionary<string, KeyValuePair<string, string>>();
            var order = new List<string>();

            for (int i = 0; i < countOfPieces; i++)
            {
                string[] currentPiece = Console.ReadLine().Split('|').ToArray();
                string piece = currentPiece[0];
                string composer = currentPiece[1];
                string key = currentPiece[2];

                if (!pieces.ContainsKey(piece))
                {
                    pieces.Add(piece, new KeyValuePair<string, string>(composer, key));
                    order.Add(piece);
                }
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] tokens = command.Split('|');

                string action = tokens[0];

                switch (action)
                {
                    case "Add":
                        {
                            string piece = tokens[1];
                            string composer = tokens[2];
                            string key = tokens[3];
                            if (!pieces.ContainsKey(piece))
                            {
                                pieces.Add(piece, new KeyValuePair<string, string>(composer, key));
                                Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                                order.Add(piece);
                            }
                            else
                            {
                                Console.WriteLine($"{piece} is already in the collection!");
                            }
                            break;
                        }
                    case "Remove":
                        {
                            string piece = tokens[1];
                            if (pieces.ContainsKey(piece))
                            {
                                pieces.Remove(piece);
                                order.Remove(piece);
                                Console.WriteLine($"Successfully removed {piece}!");
                            }
                            else
                            {
                                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                            }
                            break;
                        }
                    case "ChangeKey":
                        {
                            string piece = tokens[1];
                            string newKey = tokens[2];
                            if (pieces.ContainsKey(piece))
                            {
                                var pieceData = pieces[piece];
                                var composer = pieceData.Key;
                                pieces[piece] = new KeyValuePair<string, string>(composer, newKey);
                                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                            }
                            else
                            {
                                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                            }

                            break;
                        }
                }

                command = Console.ReadLine();
            }

            foreach (var piece in order)
            {
                Console.WriteLine($"{piece} -> Composer: {pieces[piece].Key}, Key: {pieces[piece].Value}");
            }
        }
    }
}
