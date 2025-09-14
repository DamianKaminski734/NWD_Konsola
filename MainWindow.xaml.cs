using System;

namespace NWD_Konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Podaj b: ");
            int b = int.Parse(Console.ReadLine());

            if (a < 1 || b < 1)
                Console.WriteLine("Liczby powinny być dodatnie!");
            else
                Console.WriteLine($"licz({a}, {b}) = {licz(a, b)}");
        }

        private static int licz(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
    }
}