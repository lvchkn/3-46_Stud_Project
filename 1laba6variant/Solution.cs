using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _1laba6variant
{
    public class Solution : IProgInterface
    {
        private const int SleepTime = 1;
        public Task<double> Simpson(double a, double b, int n, Func<double, double> func, IProgress<int>progress, CancellationToken token)
        {
            if (n <= 0)
            {
                throw new ArgumentException();
            }

            if ((n % 2) != 0)
            {
                throw new ArgumentException();
            }

            if (a >= b)
            {
                throw new ArgumentException();
            }
            
            return Task<double>.Factory.StartNew(() =>
            {
                double s = 0.0, h = (b - a) / n;
                int count = 0;
                
                for (int k = 1; k < n; k++)
                {
                    Interlocked.Increment(ref count);
                    token.ThrowIfCancellationRequested();
                    
                    if (k % 2 == 0)
                    {
                        s += 2.0 * func(a + k * h);
                    }
                    else
                    {
                        s += 4.0 * func(a + k * h);
                    }
                    Thread.Sleep(SleepTime);
                    progress.Report(count * 100 / n);
                }
                s = func(a) + func(b) + s + func(a + h);
                s *= h / 3.0;
             
                return s;

            }, token);
            
        }
        public Task<double> ParallelSimpson(double a, double b, int n, Func<double, double> func, IProgress<int> progress, CancellationToken token)
        {
            if (n <= 0)
            {
                throw new ArgumentException();
            }

            if ((n % 2) != 0)
            {
                throw new ArgumentException();
            }

            if (a >= b)
            {
                throw new ArgumentException();
            }

            return Task<double>.Factory.StartNew(() =>
            {
                double s = 0.0, h = (b - a) / n;
                double[] sum = new double[n];
                s = func(a + h);
                int count = 0;

                Parallel.For(1, n, new ParallelOptions() { CancellationToken = token }, (k, state) =>
                {
                    Interlocked.Increment(ref count);

                    if (token.IsCancellationRequested)
                    {
                        state.Break();
                    }

                    if (k % 2 == 0)
                    {
                        sum[k] = 2.0 * func(a + k * h);
                    }
                    else
                    {
                        sum[k] = 4.0 * func(a + k * h);
                    }
                    Thread.Sleep(SleepTime);
                    progress.Report(count * 100 / n);
                });
                
                s += func(a) + func(b) + sum.AsParallel().Sum(y => y);
                s *= h / 3.0;

                return s;

            }, token);

        }

        public Task<double> Rectangle(double a, double b, int n, Func<double, double> func, IProgress<int> progress, CancellationToken token)
        {
            if (n <= 0)
            {
                throw new ArgumentException();
            }

            if ((n % 2) != 0)
            {
                throw new ArgumentException();
            }

            if (a >= b)
            {
                throw new ArgumentException();
            }
            return Task<double>.Factory.StartNew(() =>
            {
                float k = 0.5f;
                double h = (b - a) / n;
                double sumrect = 0;
                int count = 0;

                a += h * k;

                for (int i = 0; i < n; i++)
                {
                    Interlocked.Increment(ref count);
                    token.ThrowIfCancellationRequested();
                    sumrect += func(a + (h * i));
                    Thread.Sleep(SleepTime);
                    progress.Report(count * 100 / n);
                }
                                            
                return h * sumrect;

            }, token);
        }
        public Task<double> ParallelRectangle(double a, double b, int n, Func<double, double> func, IProgress<int> progress, CancellationToken token)
        {
            if (n <= 0)
            {
                throw new ArgumentException();
            }

            if ((n % 2) != 0)
            {
                throw new ArgumentException();
            }

            if (a >= b)
            {
                throw new ArgumentException();
            }
            return Task<double>.Factory.StartNew(() =>
            {
                float k = 0.5f;
                double h = (b - a) / n;
                double[] sumrect = new double[n];
                int count = 0; 
                a += h * k;

                Parallel.For(0, n, new ParallelOptions() { CancellationToken = token }, (i, state) =>
                {
                    Interlocked.Increment(ref count);
                    if(token.IsCancellationRequested)
                    {
                        state.Break();
                    }
                    sumrect[i] = func(a + (h * i));
                    Thread.Sleep(SleepTime);
                    progress.Report(count * 100 / n);
                });
                
                double s = sumrect.AsParallel().Sum(y => y);

                return h * s;

            }, token);
        }
    }
}
