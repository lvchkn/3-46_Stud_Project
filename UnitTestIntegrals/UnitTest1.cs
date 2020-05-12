using System;
using System.Threading;
using System.Threading.Tasks;
using _1laba6variant;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIntegrals
{
    [TestClass]
    public class IntegralTest1
    {
        CancellationTokenSource _cts;

        [TestMethod]
        public async Task TestSimpsonPowX2()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0.0;
            double b = 10.0;
            int n = 100000;
            double correct_res = 333.3333;
            
            _cts = new CancellationTokenSource();
            Progress<int> progress = new Progress<int>();

            //act
            IProgInterface solution = new Solution();
            double res = await solution.Simpson(a, b, n, func, progress, _cts.Token);

            //arrange
            Assert.AreEqual(correct_res, res, 0.0001);
        }

        [TestMethod]
        public async Task TestSimpson10x()
        {
            //assert 
            Func<double, double> func = x => x * 10;
            double a = 0.0;
            double b = 10.0;
            int n = 100000;
            double correct_res = 500.0000;

            _cts = new CancellationTokenSource();
            Progress<int> progress = new Progress<int>();

            //act
            IProgInterface solution = new Solution();
            double res = await solution.Simpson(a, b, n, func, progress, _cts.Token);

            //arrange
            Assert.AreEqual(correct_res, res, 0.0001);
        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentException))]
        public async Task Test_Negative_n()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0.0;
            double b = 20.0;        
            int n = -273;

            _cts = new CancellationTokenSource();
            Progress<int> progress = new Progress<int>();

            //act
            IProgInterface solution = new Solution();
            double res1 = await solution.Simpson(a, b, n, func, progress, _cts.Token);
            double res2 = await solution.Rectangle(a, b, n, func, progress, _cts.Token);
            double res3 = await solution.ParallelSimpson(a, b, n, func, progress, _cts.Token);
            double res4 = await solution.ParallelRectangle(a, b, n, func, progress, _cts.Token);
        }

        [TestMethod]
        public async Task TestRectanglePowX2()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0.0;
            double b = 10.0;
            int n = 100000;
            double correct_res = 333.3333;

            _cts = new CancellationTokenSource();
            Progress<int> progress = new Progress<int>();

            //act
            IProgInterface solution = new Solution();
            double res = await solution.Rectangle(a, b, n, func, progress, _cts.Token);

            //arrange
            Assert.AreEqual(correct_res, res, 0.0001);
        }

        [TestMethod]
        public async Task TestRectangle10x()
        {
            //assert 
            Func<double, double> func = x => x * 10;
            double a = 0.0;
            double b = 10.0;
            int n = 100000;
            double correct_res = 500.0000;

            _cts = new CancellationTokenSource();
            Progress<int> progress = new Progress<int>();

            //act
            IProgInterface solution = new Solution();
            double res = await solution.Rectangle(a, b, n, func, progress, _cts.Token);

            //arrange
            Assert.AreEqual(correct_res, res, 0.0001);
        }       

        [TestMethod]

        [ExpectedException(typeof(ArgumentException))]
        public async Task TestWrongInterval()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 30.0;
            double b = 20.0;
            int n = 50000;

            _cts = new CancellationTokenSource();
            Progress<int> progress = new Progress<int>();

            //act
            IProgInterface solution = new Solution();
            double res1 = await solution.Simpson(a, b, n, func, progress, _cts.Token);
            double res2 = await solution.Rectangle(a, b, n, func, progress, _cts.Token);
            double res3 = await solution.ParallelSimpson(a, b, n, func, progress, _cts.Token);
            double res4 = await solution.ParallelRectangle(a, b, n, func, progress, _cts.Token);
        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentException))]

        public async Task Test_Odd_N()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 30.0;
            double b = 20.0;
            int n1 = 33;
            int n2 = 77;

            _cts = new CancellationTokenSource();
            Progress<int> progress = new Progress<int>();

            //act
            IProgInterface solution = new Solution();
            double res1 = await solution.Simpson(a, b, n1, func, progress, _cts.Token);
            double res2 = await solution.Rectangle(a, b, n1, func, progress, _cts.Token);
            double res3 = await solution.ParallelSimpson(a, b, n2, func, progress, _cts.Token);
            double res4 = await solution.ParallelRectangle(a, b, n2, func, progress, _cts.Token);
        }
    }
}
