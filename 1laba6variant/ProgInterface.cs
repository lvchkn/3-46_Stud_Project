using System;
using System.Threading;
using System.Threading.Tasks;

namespace _1laba6variant
{
    public interface IProgInterface
    {
        Task<double> Rectangle(double a, double b, int n, Func<double, double> func, IProgress<int> progress, CancellationToken token);
        Task<double> Simpson(double a, double b, int n, Func<double, double> func, IProgress<int> progress, CancellationToken token);
        Task<double> ParallelSimpson(double a, double b, int n, Func<double, double> func, IProgress<int> progress, CancellationToken token);
        Task<double> ParallelRectangle(double a, double b, int n, Func<double, double> func, IProgress<int> progress, CancellationToken token);
    }
}
