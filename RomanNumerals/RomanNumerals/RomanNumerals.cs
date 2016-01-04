using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals
{
    [TestClass]
    public class RomanNumerals
    {
        [TestMethod]
        public void TestMethod()
        {
            Assert.AreEqual("I", ToRoman(1));
        }
        [TestMethod]
        public void TestWrongNumber()
        {
            Assert.AreEqual("", ToRoman(0));
        }
        public string ToRoman(int numberInserted)
        {
            if (numberInserted >= 1) return "I" + ToRoman(numberInserted - 1);
            return "";
        }
    }
}
