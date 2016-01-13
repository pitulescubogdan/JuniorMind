using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class Panagram
    {
        [TestMethod]
        public void CheckPanagramForARandomString()
        {
            Assert.AreEqual("NO", CheckForPanagram("Gasdasfa"));
        }
        [TestMethod]
        public void CheckIfPanagramIgnoreUpperCase()
        {
            Assert.AreEqual("NO", CheckForPanagram("The"));
        }      
        [TestMethod]
        public void CheckPanagramAlphabet()
        {
            Assert.AreEqual("YES", CheckForPanagram("abcdefghijklmnopqrstuvwxyz"));
        }
        [TestMethod]
        public void CheckTheSentencePanagram()
        {
            Assert.AreEqual("YES", CheckForPanagram("The quick brown fox jumps over the lazy dog"));
        }
        public String CheckForPanagram(string sentenceInserted)
        {
            String lowerCase = sentenceInserted.ToLower();
            if (CheckPanagram(lowerCase)) return "YES";
            else return "NO";
        }
        public bool CheckPanagram(String inputString)
        {
            String output = String.Empty;
                for (int i = 0; i < 26; i++)
                    for (int j = 0; j < inputString.Length; j++)
                {
                    if ((char)('a' + i) != inputString[j])
                    {
                        return false;
                    }
                    else return true;
                }
                return true;
        }
    }
}
                
                  
                