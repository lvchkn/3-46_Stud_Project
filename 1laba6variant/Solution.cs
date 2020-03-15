using System;

namespace _1laba6variant
{
    public class Solution : IProgInterface
    {
       /* public double F(double x)
        {
            return (322 * x) - Math.Log(11 * x) - 2;
        }*/


        public double Simpson(double a, double b, double n, Func<double, double> func)
        {
            if (n < 0)
            {
                throw new ArgumentException();
            }

            double s = 0, h = (b - a) / n;

            double I2 = 0, I4 = func(a + h);

            for (int k = 2; k < n; k += 2)
            {
                I2 += func(a + k * h);
                I4 += func(a + (k + 1) * h);
            }
            s = func(a) + func(b) + 4 * I4 + 2 * I2;
            s *= h / 3;

            return s;

        }

        public double Rectangle(double a, double b, double n, Func<double, double> func)
        {
            if (n < 0)
            {
                throw new ArgumentException();
            }

            float k = 0.5f;
            double h = (b - a) / n;
            double sumrect = 0;

            a += h * k;

            for (int i = 0; i < n; i++)
            {
                sumrect += func(a + (h * i));
            }

            return h * sumrect;
        }

    }
}
