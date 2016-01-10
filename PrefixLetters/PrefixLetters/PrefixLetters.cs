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
            int widerString = 0;

            if (firstString.Length >= secondString.Length) widerString = firstString.Length;
            else widerString = secondString.Length;

                for (int i = 0; i < widerString; i++)
                {                 
                    if (firstString[i] == secondString[i])
                    {
                        result += firstString[i];

                    }else break;
                }

            return result;
        } 
        }
    }
    

