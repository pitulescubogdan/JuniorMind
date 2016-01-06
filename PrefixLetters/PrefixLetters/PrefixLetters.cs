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
            Assert.AreEqual("", checkPrefix("ab", "ac"));
        }
        public string checkPrefix(string firstString,string secondString)
        {

            return "";
        }
    }
}
