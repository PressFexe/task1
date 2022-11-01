using System;
using System.Runtime.CompilerServices;

namespace _1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            Console.WriteLine("Enter x: ");
            x = Convert.ToDouble(Console.ReadLine());
            double? result = task2(x, out int errorCode);
            Console.WriteLine(errorCode == 0 ? result : "Error");
        }

        static double? task2(double x, out int errorCode)
        {
            errorCode = 0;
            if (x < 0)
            {
                errorCode = -1;
                return null;
            }
            double a = 1;
            double result = 0;
            while (a <= x)
            {
                x -= a;
                a += 2;
                result += 1;
            }
            Console.WriteLine("Your result is:");
            return result;
        }
    }
}