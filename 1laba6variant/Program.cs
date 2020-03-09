using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1laba6variant
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static double F(double x)
        {
            return (322 * x) - Math.Log(11 * x) - 2;
        }

        public static double SimpsonMethod(double b, double a, int n)
        {
            double sum = 0;
            double h = (b - a) / n;
            for (int i = 0; i < n - 1; i++)
            {
                sum += F(a + h * i) + 4 * F(a + h * (i + 0.5)) + F(a + h * (i + 1)) * h / 6;
            }

            return sum;
        }

        class Integral
        {
            private int b;
            // свойство только для чтения
            public int Integral1 { get; }

            private int age;
            // свойство только для записи
            public int Age
            {
                set
                {
                    age = value;
                }
            }

            public int B { get => b; set => b = value; }
        }


    }
}
