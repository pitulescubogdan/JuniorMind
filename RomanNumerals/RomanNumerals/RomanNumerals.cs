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
            Assert.AreEqual("XLV", ToRoman(45));
        }
        [TestMethod]
        public void TestWrongNumber()
        {
            Assert.AreEqual("", ToRoman(0));
        }
        public string ToRoman(int numberInserted)
        {
            if (numberInserted >= 1 && numberInserted < 4) return "I" + ToRoman(numberInserted - 1);
            if (numberInserted >= 4 && numberInserted < 5) return "IV" + ToRoman(numberInserted - 4);
            if (numberInserted >= 5 && numberInserted < 9) return "V" + ToRoman(numberInserted - 5);
            if (numberInserted >= 9 && numberInserted < 5) return "IX" + ToRoman(numberInserted - 9);
            if (numberInserted >= 10 && numberInserted < 40) return "X" + ToRoman(numberInserted - 10);
            if (numberInserted >= 40 && numberInserted < 50) return "XL" + ToRoman(numberInserted - 40);
            if (numberInserted >= 50 && numberInserted < 90) return "L" + ToRoman(numberInserted - 50);
            if (numberInserted >= 90 && numberInserted < 100) return "XC" + ToRoman(numberInserted - 90);
            if (numberInserted == 100) return "C" + ToRoman(numberInserted - 100);
            

            return "";
        }
    }
}
