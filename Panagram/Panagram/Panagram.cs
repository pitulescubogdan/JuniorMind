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
        public string CheckForPanagram(string sentenceInserted)
        {
            int countCharacters;
            int countAlphabet = 0;
            char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g',
                'h', 'i', 'j', 'k', 'l', 'm', 'n' ,'o','p','q','r','s','t','u','v','w','x','y','z'};
            string senteLowerCase = sentenceInserted.ToLower();           
            char[] sentenceInCharacteres = senteLowerCase.ToCharArray();
            int sentenceLength = sentenceInCharacteres.Length;

            for(int i = 0; i < alphabet.Length; i++)
            {
                countCharacters = 0;
                for(int j = 0; j < sentenceInCharacteres.Length; j++)
                {
                    if (alphabet[i].Equals(sentenceInCharacteres[j]))
                    {
                        countCharacters++;                       
                    }                  
                }
                if (countCharacters != 0)
                {
                    countAlphabet++;
                }
            }
            if(countAlphabet == 26)
            {
                return "YES";
            }
            return "NO";             
        }
    }
}
