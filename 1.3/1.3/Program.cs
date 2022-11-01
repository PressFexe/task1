using System;

namespace _1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(result(ref x, ref y));
        }

        static int result(ref int x, ref int y)
        {


            while (x != y)
            {
                if (x > y)
                {
                    x -= y;
                }
                else
                {
                    y -= x;
                }
            }
            Console.WriteLine("Your result is:");
            return x;
        }

    }
}