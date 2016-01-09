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

            return "NO";          
        }
        public bool CheckPanagram(String inputString)
        {
            String alphabet = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;
            for (int i = 0; i < alphabet.Length; i++)       
                for (int j = 0; j<inputString.Length; j++)
            {
                    if (alphabet[i]==inputString[j])
                    {
                        count++;
                        break;
                    }
            }
            if (count == 26) return true;
            else return false;

        }
    }
}
