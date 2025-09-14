using System;

namespace NWD_Konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Podaj a: ");
            bool isSucces = int.TryParse(Console.ReadLine(), out a);

            if (!isSucces || a < 1)
            {
                Console.WriteLine("Liczba a jest niepoprawna");
                return;
            }

            Console.Write("Podaj b: ");
            isSucces = int.TryParse(Console.ReadLine(), out b);

            if (!isSucces || b < 1)
            {
                Console.WriteLine("Liczba b jest niepoprawna");
                return;
            }

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