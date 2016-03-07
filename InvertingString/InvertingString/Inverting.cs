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
            if(inputString.Length > 0)
            {
                return inputString[inputString.Length - 1] + ReverseString(inputString.Substring(0,inputString.Length - 1));
            }

            return inputString;
        }

    }
}
