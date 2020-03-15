using System;

namespace _1laba6variant
{
    public interface IProgInterface
    {
        double Rectangle(double a, double b, double h, Func<double, double> func);
        double Simpson(double a, double b, double n, Func<double, double> func);

    }
}
