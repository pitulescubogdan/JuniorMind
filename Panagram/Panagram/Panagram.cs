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
            Assert.AreEqual("NO", CheckForPanagram("abc"));
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
            int sentenceLength = 0;
            char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g',
                'h', 'i', 'j', 'k', 'l', 'm', 'n' ,'o','p','q','r','s','t','u','v','w','x','y','z'};
            string senteLowerCase = sentenceInserted.ToLower();           
            char[] sentenceInCharacteres = sentenceInserted.ToCharArray();



            for(int i = 0; i < sentenceInCharacteres.Length; i++)
            {
                for(int j = 0; j < alphabet.Length; j++)
                {
                    if( alphabet[j].Equals(sentenceInCharacteres[i]))
                    {
                        sentenceLength++;
                    }
                }
            }         
            if(sentenceLength == alphabet.Length || sentenceInCharacteres.Length > alphabet.Length)
            {
                return "YES";
            }
            return "NO";    
        }
    }
}
