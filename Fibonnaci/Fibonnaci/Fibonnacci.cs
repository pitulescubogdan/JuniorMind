using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonnaci
{
    [TestClass]
    public class Fibonnacci
    {
        [TestMethod]
        public void Fibbonacci()
        {
            Assert.AreEqual(8, CalculateFibonnacci(6));
        }
        public int CalculateFibonnacci(int n)
        {
            int previous = 0;
            return CalculateFibonnacci(n, ref previous);
        }
        public int CalculateFibonnacci(int number, ref int previous)
        {
            if (number < 2) return number;
            int beforePrevious = 0;
            previous = CalculateFibonnacci(number - 1, ref beforePrevious);

            return previous + beforePrevious;
        }
    }
}
