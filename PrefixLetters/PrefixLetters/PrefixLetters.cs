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
        public string checkPrefix(string firstString,string secondString)
        {
            string result="";
            char constantForFirstArray;
            string[] firstArray = { firstString };

            for (int i = 0; i < firstString.Length; i++)               
                {
                    if (firstString[i] == secondString[i])
                    {
                        constantForFirstArray = firstString[i];
                        result += constantForFirstArray;
                    }
                }

            return result;
        }
    }
}
