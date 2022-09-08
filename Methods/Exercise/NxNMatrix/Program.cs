using System;
using System.Text;

namespace NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Matrix(n);

        }

        static int Matrix(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int i1 = 0; i1 < num; i1++)
                {
                    Console.Write($"{num} ");
                }

                Console.WriteLine();
            }
           

            return num;
        }
    }
}
