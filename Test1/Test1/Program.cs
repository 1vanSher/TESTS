using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, max, srd, min;
            Console.WriteLine("Введите значение длин сторон");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            sort(a, b, c, out max, out srd, out min);
            calk(a, b, c);
            cornerСalk(a, b, c, max, srd, min);
        }
        static void calk(double a, double b, double c)
        {
            double p, square;
            p = (a + b + c) / 2;
            if (a < 0 || b < 0 || c < 0) Console.WriteLine("Error");
            else if (a + b > c && a + c > b && b + c > a)
            {
                square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine(square);
            }
            else Console.WriteLine("Error");

            if (a == b && a == c)
            {
                Console.WriteLine("Равносторонний");
            }
            else if (a != b && a != c && b != c)
            {
                Console.WriteLine("Разносторонний");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Равнобедренный");
            }
        }
        static void cornerСalk(double a, double b, double c, double max, double srd, double min)
        {
            double p, S, d, k;
            p = (a + b + c) / 2;

            if (a < 0 || b < 0 || c < 0) Console.WriteLine("Error");
            else if (a + b > c && a + c > b && b + c > a)
            {
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine(S);
            }
            else Console.WriteLine("Error");

            d = min * min + srd * srd;
            k = max * max;
            if (d > k) Console.WriteLine("Остроугольный");
            else if (d < k) Console.WriteLine("Тупоугольный");
            else if (d == k) Console.WriteLine("Прямоугольный");

        }
        static void sort(double a, double b, double c, out double mx, out double sr, out double mn)
        {
            mx = a;
            if (b > mx) mx = b;
            if (c > mx) mx = c;

            mn = a;
            if (b < mn) mn = b;
            if (c < mn) mn = c;
            sr = a + b + c - mx - mn;
        }
    }
}
