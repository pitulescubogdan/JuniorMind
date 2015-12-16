using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemaSportiv
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = calculRepetitii(4);
            Assert.AreEqual(16, result);
        }
        public int calculRepetitii(int runde)
        {
            int repetitii = runde * runde;

            return repetitii;
        }
    }
}
