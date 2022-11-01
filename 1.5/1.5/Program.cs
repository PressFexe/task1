using System;

namespace _1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[3, 3] { { 2, 7, 7 },
                                             { 4, 9, 2 },
                                             { 1, 5, 8 } };
            double[][] b = new double[a.GetLength(0)][];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > 0)
                    {
                        count++;
                    }
                }
                b[i] = new double[count];
            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                int k = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] % 2 == 0)
                    {
                        b[i][k++] = a[i, j];
                    }
                }
            }
            Console.WriteLine("Your result is:\n");
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b[i].Length; j++)
                {
                    Console.Write(b[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}