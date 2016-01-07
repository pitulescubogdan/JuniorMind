using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrefixLetters
{
    [TestClass]
    public class PrefixLetters
    {
        [TestMethod]
        public void CheckForPrefix()
        {
            Assert.AreEqual("a", checkPrefix("ab", "aa"));
        }
        [TestMethod]
        public void CheckForPrefixForDifferentLengths()
        {
            Assert.AreEqual("aaa", checkPrefix("aaab", "aaaabbbaa"));
        }
        [TestMethod]
        public void CheckForNonePrefix()
        {
            Assert.AreEqual("", checkPrefix("abaaxaa", "xbaaabbbi"));
        }
        public string checkPrefix(string firstString, string secondString)
        {
            string result = "";
            if (firstString.Length < secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {                 
                    if (firstString[i] == secondString[i])
                    {
                        result += firstString[i];

                    }else break;
                }
            } else
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    if (firstString[i] == secondString[i])
                    {
                        result += firstString[i];
                    }else break;
                }
            }
            return result;
        }
    }
}
    

