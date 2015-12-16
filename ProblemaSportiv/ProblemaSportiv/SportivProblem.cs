using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemaSportiv
{
    [TestClass]
    public class SportivProblem
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = calculRepetitii(6);
            Assert.AreEqual(36, result);
        }
        public int calculRepetitii(int runde)
        {
            int repetitii = runde * runde;

            return repetitii;
        }
    }
}
