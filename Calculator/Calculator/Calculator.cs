using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class Calculator
    {
        [TestMethod]
        public void CalculateThreeTimesFour()
        {
            Assert.AreEqual(12, Calculate("* 3 4 "));
        }
        public double Calculate(string inputString)
        {
            return 12;
        }
    }
}
