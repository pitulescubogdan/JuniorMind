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
            Assert.AreEqual("a", CheckPrefix("ab", "aa"));
        }
        [TestMethod]
        public void CheckForPrefixForDifferentLengths()
        {
            Assert.AreEqual("aaa", CheckPrefix("aaab", "aaaabbbaa"));
        }
        [TestMethod]
        public void CheckForNonePrefix()
        {
            Assert.AreEqual("", CheckPrefix("abaaxaa", "xbaaabbbi"));
        }
        public string CheckPrefix(string firstString, string secondString)
        {
            string result = "";
            int smallerString = 0;

            smallerString = Math.Min(firstString.Length, secondString.Length);

            for (int i = 0; i < smallerString; i++)
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
    

