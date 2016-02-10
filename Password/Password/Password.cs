using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class Password
    {
        [TestMethod]
        public void GetPasswordOfSmallCharacters()
        {
            Assert.AreEqual("",GetPassword(0));
        }

        public string GetPassword(int noOfChars)
        {
            return "";
        }
    }
}
