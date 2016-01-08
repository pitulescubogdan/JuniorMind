using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagram
{
    [TestClass]
    public class Anagram
    {
        [TestMethod]
        public void AnagramForTwoLetters()
        {
            Assert.AreEqual(2, CalculateAnagram("ab"));
        }
        [TestMethod]
        public void AnagramForFourLetters()
        {
            Assert.AreEqual(24, CalculateAnagram("aabb"));

        }
        public int CalculateAnagram(String inputString)
        {
            
            return CalculateFactorial(inputString.Length);
        }
        public int CalculateFactorial(int number)
        {
            int result = 1;      
            while(number != 0)
            {
                result = result * number;
                number--;
            }

            return result;
        }
    }
}
