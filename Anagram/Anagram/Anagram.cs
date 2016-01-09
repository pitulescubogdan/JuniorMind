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
        public void OccurencesForTwoOrMore()
        {
            Assert.AreEqual(2, CalculateOccurences("aab",'a'));
        }

        public int CalculateAnagram(String inputString)
        {
            int result = 1;

            for(int i = 'a'; i < 'z'; i++)
            {
                result *= CalculateFactorial(CalculateOccurences(inputString,(char) i));
            }

            return CalculateFactorial(inputString.Length) / result;
        }

        public int CalculateOccurences(String inputString, char x)
        {
            int count = 0;
            for(int i = 0;i < inputString.Length; i++)
            {
                if (x == inputString[i]) count++;
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
