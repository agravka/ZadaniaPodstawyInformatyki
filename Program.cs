using System;

namespace summary
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = 1000000;
            var watch = System.Diagnostics.Stopwatch.StartNew();

            Brutal(n);
            watch.Stop();
            Console.WriteLine($"Funkcja {nameof(Brutal)} - czas wykonania: {watch.ElapsedMilliseconds} ms");

            watch = System.Diagnostics.Stopwatch.StartNew();
            Slow(n);
            watch.Stop();
            Console.WriteLine($"Funkcja {nameof(Slow)} - czas wykonania: {watch.ElapsedMilliseconds} ms");

            watch = System.Diagnostics.Stopwatch.StartNew();
            Quick(n);
            watch.Stop();
            Console.WriteLine($"Funkcja {nameof(Quick)} - czas wykonania: {watch.ElapsedMilliseconds} ms");
            Console.ReadLine();
        }


        static void Brutal(uint n)
        {
            uint wynik = 0;

            for (uint i = 1; i <= n; i++)
            {
                for (uint j = 1; j <= i; j++)
                {
                    wynik += 1;
                }
            }
            Console.WriteLine($"Wynik: {wynik}");
        }

        static void Slow(uint n)
        {
            uint wynik = 0;

            for (uint i = 1; i <= n; i++)
            {
                wynik += i;
            }
            Console.WriteLine($"Wynik: {wynik}");
        }

        static void Quick(uint n)
        {
            uint wynik = (n * (n + 1)) / 2;
            Console.WriteLine($"Wynik: {wynik}");
        }

    }
}
