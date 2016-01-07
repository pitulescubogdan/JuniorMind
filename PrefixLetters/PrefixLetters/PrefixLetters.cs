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
            Assert.AreEqual("aaa", checkPrefix("aaab", "aaabbbaa"));
        }
        [TestMethod]
        public void CheckForNonePrefix()
        {
            Assert.AreEqual("", checkPrefix("baaaxaa", "xaaaabbbi"));
        }
        public string checkPrefix(string firstString,string secondString)
        {
            string result="";

            for (int i = 0; i < firstString.Length; i++)               
                {
                    if (firstString[i] == secondString[i] && !(firstString[i] != firstString[0]))
                    {   
                                       
                        result += firstString[i];
                    }
                }

            return result;
        }
    }
}
