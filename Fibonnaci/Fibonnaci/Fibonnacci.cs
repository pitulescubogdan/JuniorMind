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
            Assert.AreEqual(5, CalculateFibonnacci(5));
        }
        public int CalculateFibonnacci(int number)
        {
            if (number < 2) return number;
            else return (CalculateFibonnacci(number - 1) + CalculateFibonnacci(number - 2));
        }
    }
}
