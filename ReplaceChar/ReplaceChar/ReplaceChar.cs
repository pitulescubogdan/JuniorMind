using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ReplaceChar
{
    [TestClass]
    public class ReplaceChar
    {
        [TestMethod]
        public void CheckReplacement()
        {
            Assert.AreEqual("aHic", ReplaceChars("abc","Hi",'b'));
        }
        [TestMethod]
        public void CheckSwapWithTwoLeters()
        {
            Assert.AreEqual("aHiHic", ReplaceChars("abbc", "Hi", 'b'));

        }
        public string ReplaceChars(string inputString,string wordToReplace,char charReplaced)
        {
            string result = string.Empty;
            if (!inputString.Contains(charReplaced))
            {
                return inputString;
            }

            return inputString.Replace(charReplaced.ToString(),wordToReplace);
        }
    }
}
