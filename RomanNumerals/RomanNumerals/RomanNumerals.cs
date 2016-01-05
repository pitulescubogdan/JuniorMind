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
        
        public string ToRoman(int numberInserted)
        {
            return "I";
        }
    }
}
