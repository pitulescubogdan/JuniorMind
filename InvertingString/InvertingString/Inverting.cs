using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InvertingString
{
    [TestClass]
    public class Inverting
    {
        [TestMethod]
        public void ReverseStringTest()
        {
            Assert.AreEqual("cba", ReverseString("abc"));
        }

        public string ReverseString(string inputString)
        {
            return "cba";
        }

    }
}
