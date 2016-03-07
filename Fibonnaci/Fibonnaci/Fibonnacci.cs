using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonnaci
{
    [TestClass]
    public class Fibonnacci
    {
        [TestMethod]
        public void Fibonacci()
        {
            Assert.AreEqual(5, CalculateFibonacci(5));
        }
        [TestMethod]
        public void FibonacciOfSix()
        {
            Assert.AreEqual(8, CalculateFibonacci(6));
        }
        [TestMethod]
        public void FibonacciOf65()
        {
            Assert.AreEqual(6765, CalculateFibonacci(20));
        }
        public int CalculateFibonacci(int number)
        {
            if (number < 2) return number;
            else return (CalculateFibonacci(number - 1) + CalculateFibonacci(number - 2));
        }
    }
}
