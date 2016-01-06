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
            Assert.AreEqual("aa", checkPrefix("ab", "aa"));
        }
        public string checkPrefix(string firstString,string secondString)
        {
            string result="";
            char constantForFirstArray;
            string[] firstArray = { firstString };

            for (int i = 0; i < firstString.Length; i++)
                for (int j = 0; j < secondString.Length; j++)
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
