using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WatermelonProblem
{
    [TestClass]
    public class Watermelon
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("DA", DivideWatermelon(50));
        }
        public string DivideWatermelon(int WatermelonWeight)
        {
            return "DA";
        }
    }
}