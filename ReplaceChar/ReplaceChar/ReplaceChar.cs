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
        [TestMethod]
        public void ReplaceAtBeginningAandAtTheEnd()
        {
            Assert.AreEqual("HiabHibHicHi", ReplaceChars("xabxbxcx", "Hi", 'x'));

        }
        public string ReplaceChars(string inputString,string wordToReplace,char charReplaced)
        {
            string result = string.Empty;
            
            if (inputString.Length <= 1)
            {
                return (inputString[0].ToString().Contains(charReplaced)) ? wordToReplace : inputString;
            }
            if (inputString[inputString.Length - 1].ToString().Contains(charReplaced))
            {
                return ReplaceChars(inputString.Substring(0, inputString.Length - 1), wordToReplace, charReplaced) + wordToReplace;
            }
            return ReplaceChars(inputString.Substring(0, inputString.Length - 1),wordToReplace,charReplaced) + inputString[inputString.Length-1];
        }
    }
}
