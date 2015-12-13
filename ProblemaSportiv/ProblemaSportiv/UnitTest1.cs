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
            int sum = 0;
            for(int i = 1;i <= runde; i++)
            {
                sum = sum + i;
            }
            int repetitii =2*(sum)-runde;

            return repetitii;
        }
    }
}
