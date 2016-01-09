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
            result = CalculateFactorial(inputString.Length)/
            CalculateFactorial(CountOccurences(inputString)) * CalculateFactorial(CalculateDifferences(inputString));

            return result;          
        }
        public int CalculateDifferences(String inputString)
        {
            int count=0;
            for(int i = 0; i < inputString.Length; i++)
                for(int j=0;j<inputString.Length;j++)
            {
                    if (inputString[i] == inputString[j])
                    {
                        break;
                    } else count++;
            }

            return count;
        }
        public int CountOccurences(String inputString)
        {
            int count = 0;
            for(int i = 0;i<inputString.Length; i++)
            {
                 count = inputString.Split(inputString[i]).Length - 1;
            }

            return count;
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
