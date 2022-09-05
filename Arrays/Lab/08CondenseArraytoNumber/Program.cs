using System;
using System.Linq;
using System.Threading.Channels;

namespace _08CondenseArraytoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integersInts = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] condensedInts = new int[integersInts.Length - 1];

            while (integersInts.Length > 1)
            {
                for (int i = 0; i <= integersInts.Length - 2; i++)
                {
                    condensedInts[i] = integersInts[i] + integersInts[i + 1];

                    if (i == integersInts.Length - 2 )
                    {
                        integersInts = condensedInts;
                        condensedInts = new int[integersInts.Length - 1];
                    }
                }
            }

            Console.WriteLine(integersInts[0]);
        }
    }
}
