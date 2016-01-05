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
            string result = "";
            string[] romanNumerals = { "", "X", "IX", "V", "IV", "I" };
            int[] numbers = { 10, 9, 5, 4, 1, 0 };

            for(int i = 0; i < romanNumerals.Length; i++)
            {
                if(numberInserted - numbers[i] > 0)
                {
                    result = romanNumerals[i];
                }
            }

            return result;               
        }
    }
}
