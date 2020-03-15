using System;
using _1laba6variant;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIntegrals
{
    [TestClass]
    public class IntegralTest1
    {
        [TestMethod]
        public void TestSimpsonPowX2()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0;
            double b = 10;
            double n = 100000;
            double correct_res = 333.3333;

            //act
            IProgInterface solution = new Solution();
            double res = solution.Simpson(a, b, n, func);

            //arrange
            Assert.AreEqual(correct_res, res, 0.0001);
        }

        [TestMethod]
        public void TestSimpson10x()
        {
            //assert 
            Func<double, double> func = x => x * 10;
            double a = 0;
            double b = 10;
            double n = 100000;
            double correct_res = 500.0000;

            //act
            IProgInterface solution = new Solution();
            double res = solution.Simpson(a, b, n, func);

            //arrange
            Assert.AreEqual(correct_res, res, 0.0001);
        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentException))]
        public void TestSimpson_negative_n()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0;
            double b = 20;
            int n = -273;

            //act
            IProgInterface solution = new Solution();
            double res = solution.Simpson(a, b, n, func);
        }

        [TestMethod]
        public void TestRectanglePowX2()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0;
            double b = 10;
            double n = 100000;
            double correct_res = 333.3333;

            //act
            IProgInterface solution = new Solution();
            double res = solution.Rectangle(a, b, n, func);

            //arrange
            Assert.AreEqual(correct_res, res, 0.0001);
        }

        [TestMethod]
        public void TestRectangle10x()
        {
            //assert 
            Func<double, double> func = x => x * 10;
            double a = 0;
            double b = 10;
            double n = 100000;
            double correct_res = 500.0000;

            //act
            IProgInterface solution = new Solution();
            double res = solution.Rectangle(a, b, n, func);

            //arrange
            Assert.AreEqual(correct_res, res, 0.0001);
        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentException))]
        public void TestRectangle_negative_n()
        {
            //assert 
            Func<double, double> func = x => x * x;
            double a = 0;
            double b = 20;
            int n = -273;

            //act
            IProgInterface solution = new Solution();
            double res = solution.Rectangle(a, b, n, func);
        }
    }
}
