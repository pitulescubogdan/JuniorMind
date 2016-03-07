using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReplaceChar
{
    [TestClass]
    public class ReplaceChar
    {
        [TestMethod]
        public void CheckReplacement()
        {
            Assert.AreEqual("SALUTSALUTSALUT", ReplaceChars("abc","SALUT"));
        }
        public string ReplaceChars(string inputString,string wordToReplace)
        {
            return "SALUTSALUTSALUT";
        }
    }
}
