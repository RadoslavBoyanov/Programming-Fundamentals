using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _03ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int piecesOfCollection = int.Parse(Console.ReadLine());

            for (int i = 0; i < piecesOfCollection; i++)
            {
                List<string> pieces = Console.ReadLine().Split('|').ToList();

                string piese = pieces[0];
                string composer = pieces[1];
                string key = pieces[2];

            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Stop")
                {
                    break;
                }

                string[] tokens = command.Split('|').ToArray();

                string inputCommand = tokens[0];

                switch (inputCommand)
                {
                    case "Add":
                       
                        break;
                }
            }
        }
    }
}
