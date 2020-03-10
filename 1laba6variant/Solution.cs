using System;

namespace _1laba6variant
{
    class Solution : ProgInterface
    {

        public double F(double x)
        {
            return (322 * x) - Math.Log(11 * x) - 2;
        }


        public double Simpson(double a, double b, double n)
        {
            double x, h, s;

            h = (b - a) / n;
            s = 0;
            x = a + h;

            while (x < b)
            {
                s += 4 * F(x);
                x += h;
                s += 2 * F(x);
                x += h;
            }
            s = h / 3 * (s + F(a) - F(b));

            // Console.WriteLine("Интеграл = " + s);
            // Console.ReadKey();

            return s;
        }
    }
}
