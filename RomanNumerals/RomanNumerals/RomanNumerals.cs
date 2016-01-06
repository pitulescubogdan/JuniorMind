using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals
{
    [TestClass]
    public class RomanNumerals
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("I", ToRoman(1));
        }
        public string ToRoman(int numberInserted)
        {
            String result = "";
            String[] romanNumerals = { "X", "IX", "V", "IV", "I" };
            int[] numbers = { 10, 9, 5, 4, 1 };

            for(int i = numbers.Length -1; i>=0; i--)
            {
                if(numberInserted - numbers[i] >= 0)
                {
                    result += romanNumerals[i];
                }
            }

            return result;
        }
    }
}
