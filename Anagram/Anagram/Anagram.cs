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
        public void AnagramForThreeLetters()
        {
            Assert.AreEqual(6, CalculateAnagram("abc"));

        }
        [TestMethod]
        public void AnagramForFourLetters()
        {
            Assert.AreEqual(24, CalculateAnagram("abcd"));
        }
        [TestMethod]
        public void AnagramForThreeLettersButWithSimiliarities()
        {
            Assert.AreEqual(3, CalculateAnagram("aab"));
        }
        public int CalculateAnagram(String inputString)
        {
            int result = 0;
            int countDifferent = 0;
            int count = 0;

            for(int i = 0; i < inputString.Length; i++)
                for(int j = 0; j < inputString.Length; j++)
                {
                    if (inputString[i] == inputString[j]) count++;
                    else countDifferent++;
                }

            result = CalculateFactorial(inputString.Length) /
                (CalculateFactorial(count) * CalculateFactorial(countDifferent));               

            return result;
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
