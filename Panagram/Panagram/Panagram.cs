using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class Panagram
    {
        [TestMethod]
        public void CheckIfPanagram()
        {
            Assert.AreEqual("NO", CheckForPanagram("Gasdasfa"));
        }
        [TestMethod]
        public void CheckIfPanagramIgnoreUpperCase()
        {
            Assert.AreEqual("NO", CheckForPanagram("The"));
        }      
        [TestMethod]
        public void CheckifPanagramHappens()
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
            String alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < inputString.Length; i++)       
                for (int j = 0; j<alphabet.Length; j++)
            {
                    if (inputString[i] != alphabet[j])
                    {
                        return false;
                    }                               
            }
            return true;       
        }
    }
}
