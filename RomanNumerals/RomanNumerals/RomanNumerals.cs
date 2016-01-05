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
            string[] romanNumerals = {"", "V", "IV", "I" };
            int[] numbers = {0, 5, 4, 1 };

           for(int i = 0; i < romanNumerals.Length; i++)
            {
                for(int j = 0; j < numbers.Length; j++)
                {
                    if(numberInserted - numbers[j]> 0)
                    {
                        result = romanNumerals[i];
                    }
                }
            }

            return result;               
        }
    }
}
