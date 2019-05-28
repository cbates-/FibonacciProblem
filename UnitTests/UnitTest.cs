using System;
using FibonacciCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        private FiboCalc Fibo = null;
        // 0, 1, 2, 3, 4, 5, 6, 7,  8,  9
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34

        [TestInitialize]
        public void TestInit() { Fibo = new FiboCalc(); }

        [TestMethod]
        public void TestZeroth()
        {
            int res = Fibo.Fib(0);
            Assert.AreEqual(0, res, $"Expected: 0, got: {res}");
        }

        [TestMethod]
        public void TestFirst()
        {
            int exp = 1;
            int res = Fibo.Fib(1);
            Assert.AreEqual(exp, res, $"Expected: {exp}, got: {res}");
        }

        [TestMethod]
        public void TestSecond()
        {
            int exp = 1;
            int res = Fibo.Fib(2);
            Assert.AreEqual(exp, res, $"Expected: {exp}, got: {res}");
        }

        [TestMethod]
        public void TestThird()
        {
            int exp = 2;
            int res = Fibo.Fib(3);
            Assert.AreEqual(exp, res, $"Expected: {exp}, got: {res}");
        }

        [TestMethod]
        public void TestSixth()
        {
            int exp = 8;
            int res = Fibo.Fib(6);
            Assert.AreEqual(exp, res, $"Expected: {exp}, got: {res}");
        }

        [TestMethod]
        public void NegTest()
        {
            Assert.ThrowsException<ArgumentException>(() => Fibo.Fib(-1));
        }

    }
}
