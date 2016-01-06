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
            String[] romanNumerals = { "I", "IV", "V", "IX", "IX" };
            int[] numbers = { 1, 4, 5, 9, 10 };

            for(int i = numbers.Length -1; i>=0; i--)
            {
                if(numberInserted - numbers[i] >= 0)
                    while(numberInserted - numbers[i] >=0)
                {
                    result = result + romanNumerals[i];
                    numberInserted = numberInserted - numbers[i];
                }
            }

            return result;
        }
    }
}
